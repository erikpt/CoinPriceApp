Public Class Form1

    Private api As CryptoCompareMinAPI
    Private coin1Snapshot As CryptoCompareMinAPI.CoinSnapshot
    Private coin1LastPrice As Double = 0
    Private coin1HighestPrice As Double = 0
    Private mouseIsDown As Boolean = False
    Private Xmod As Long = 0
    Private Ymod As Long = 0
    Private HoldColor As Color
    Private HoldColorCounter As Byte

    Function ConvertUnixDate(unixdate As Long) As DateTime
        Dim dt As New DateTime(1970, 1, 1)
        Return dt.AddSeconds(unixdate)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If (Not IsNothing(Me.cboCoinFrom.SelectedItem)) And (Not IsNothing(Me.cboCoinTo.SelectedItem)) Then
            coin1Snapshot = api.GetSnapshotCoinPair(Me.cboCoinFrom.SelectedItem, Me.cboCoinTo.SelectedItem)
        Else
            coin1Snapshot = api.GetSnapshotCoinPair
        End If
        Me.Coin1GroupBox.Text = coin1Snapshot.Data.AggregatedData.FROMSYMBOL & "/" & coin1Snapshot.Data.AggregatedData.TOSYMBOL
        Me.coin1LastPrice = coin1Snapshot.Data.AggregatedData.PRICE
        Me.Text = Coin1GroupBox.Text & "Current Price: " & FormatDouble(Me.coin1LastPrice) '.ToString("$0.00")
        Dim lud As DateTime = ConvertUnixDate(coin1Snapshot.Data.AggregatedData.LASTUPDATE).ToLocalTime
        Me.Coin1Vol24.Text = coin1Snapshot.Data.AggregatedData.VOLUME24HOUR.ToString("#,###.000")
        Me.Coin1LastUpdate.Text = lud.ToShortDateString & " " & lud.ToShortTimeString
        Me.Coin1Open24.Text = FormatDouble(coin1Snapshot.Data.AggregatedData.OPEN24HOUR) '.ToString("$0.00")
        If coin1HighestPrice < coin1Snapshot.Data.AggregatedData.HIGH24HOUR Then
            coin1HighestPrice = coin1Snapshot.Data.AggregatedData.HIGH24HOUR
        End If
        Me.Coin1High24.Text = FormatDouble(coin1HighestPrice) '.ToString("$0.00")
        Me.Coin1Low24.Text = FormatDouble(coin1Snapshot.Data.AggregatedData.LOW24HOUR) '.ToString("$0.00")
        Me.Coin1OpenDay.Text = FormatDouble(coin1Snapshot.Data.AggregatedData.OPENDAY) '.ToString("$0.00")
        Me.Coin1LowDay.Text = FormatDouble(coin1Snapshot.Data.AggregatedData.LOWDAY) '.ToString("$0.00")
        Me.Coin1HighDay.Text = FormatDouble(coin1Snapshot.Data.AggregatedData.HIGHDAY) '.ToString("$0.00")
        Me.Coin1Exchange.Text = coin1Snapshot.Data.AggregatedData.LASTMARKET
        If Me.Coin1RefreshTimer.Enabled Then
            Me.Coin1RefreshTimer.Enabled = False
        Else
            Me.Coin1RefreshTimer.Enabled = True
        End If
    End Sub

    Private Function GetCurrencySymbol(currency As String) As String
        Select Case currency
            Case "USD", "CAD", "AUD"
                Return Char.ConvertFromUtf32(&H24)
            Case "EUR"
                Return Char.ConvertFromUtf32(&H20AC)
            Case "GBP"
                Return Char.ConvertFromUtf32(&HA3)
            Case "RUB"
                Return Char.ConvertFromUtf32(&H20BD)
            Case Else
                Return currency & " "
        End Select
    End Function

    Private Function FormatDouble(value As Double) As String
        Return value.ToString(GetCurrencySymbol(Me.cboCoinTo.SelectedItem) & "0.00")
    End Function

    Private Sub Coin1RefreshTimer_Tick(sender As Object, e As EventArgs) Handles Coin1RefreshTimer.Tick
        'Dim info As CryptoCompareMinAPI.PriceInfo
        Dim kvp As Generic.Dictionary(Of String, Double)
        If (Not IsNothing(Me.cboCoinFrom.SelectedItem)) And (Not IsNothing(Me.cboCoinTo.SelectedItem)) Then
            kvp = api.GetPriceCoinPair(Me.cboCoinFrom.SelectedItem, Me.cboCoinTo.SelectedItem)
        Else
            kvp = api.GetPriceCoinPair()
        End If
        Try
            If kvp.First.Key = "ERROR" Then
                Exit Sub
            End If
        Catch ex As Exception
            '//do nothing
        End Try
        Dim currentPrice As Double = kvp.Item(Me.cboCoinTo.SelectedItem)
        Dim open As Double = coin1Snapshot.Data.AggregatedData.OPEN24HOUR
        Dim gainLossAmt As Double = currentPrice - open
        'Dim gainLossAmt As Double = info.USD - open
        Dim gainLossPct As Double = Math.Abs(gainLossAmt) / open
        Me.Coin1Price.Text = FormatDouble(currentPrice) '.ToString("$0.00")
        'Me.Coin1Price.Text = info.USD.ToString("$0.00")
        If currentPrice > open Then
            Me.Coin1Price.ForeColor = Color.LightGreen
            Me.Coin1PriceDelta.ForeColor = Color.LightGreen
            Me.Coin1PriceDelta.Text = "(+" & FormatDouble(gainLossAmt) & " +" & gainLossPct.ToString("0.00%") & ")"
            'Me.Coin1PriceDelta.Text = "(+" & gainLossAmt.ToString("$0.00") & " +" & gainLossPct.ToString("0.00%") & ")"
        ElseIf currentPrice < coin1Snapshot.Data.AggregatedData.OPEN24HOUR Then
            Me.Coin1Price.ForeColor = Color.Red
            Me.Coin1PriceDelta.ForeColor = Color.Red
            Me.Coin1PriceDelta.Text = "(" & FormatDouble(gainLossAmt) & " -" & gainLossPct.ToString("0.00%") & ")"
        Else
            Me.Coin1Price.ForeColor = Color.Yellow
            Me.Coin1PriceDelta.ForeColor = Color.Yellow
            Me.Coin1PriceDelta.Text = "(" & FormatDouble(gainLossAmt) & " " & gainLossPct.ToString("0.00%") & ")"
        End If
        If currentPrice > coin1LastPrice Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            Me.HoldColor = Color.LawnGreen
            Me.HoldColorCounter = 2
        ElseIf currentPrice < coin1LastPrice Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
            Me.HoldColor = Color.OrangeRed
            Me.HoldColorCounter = 2
        End If
        If HoldColorCounter > 0 Then
            Me.HoldColorCounter -= 1
            Me.Coin1PriceDelta.ForeColor = Me.HoldColor
            Me.Coin1Price.ForeColor = Me.HoldColor
        End If
        coin1LastPrice = currentPrice
        If coin1HighestPrice < coin1LastPrice Then
            coin1HighestPrice = coin1LastPrice
            Me.Coin1High24.Text = FormatCurrency(coin1HighestPrice) '.ToString("0.00%")
            Me.Coin1High24.ForeColor = Color.LightGreen
            Me.Coin1HighDay.ForeColor = Color.LightGreen
            Me.Coin1HighDay.Text = FormatCurrency(coin1HighestPrice) '.ToString("0.00%")
        Else
            Me.Coin1High24.ForeColor = Color.White
            Me.Coin1HighDay.ForeColor = Color.White
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        api = New CryptoCompareMinAPI
        Button1_Click(New Object, New EventArgs)
        Me.Coin1SnapTimer.Enabled = True
        Me.Coin1GroupBox.Cursor = Cursors.Cross
        Me.TopMost = True
        If (IsNothing(Me.cboCoinFrom.SelectedItem)) Then
            Me.cboCoinFrom.SelectedItem = "IOT"
        End If
        If (IsNothing(Me.cboCoinTo.SelectedItem)) Then
            Me.cboCoinTo.SelectedItem = "USD"
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Coin1SnapTimer_Tick(sender As Object, e As EventArgs) Handles Coin1SnapTimer.Tick
        Button1_Click(New Object, New EventArgs)
    End Sub

    Private Sub Coin1GroupBox_MouseDown(sender As Object, e As MouseEventArgs) Handles Coin1GroupBox.MouseDown
        Me.mouseIsDown = True
        Xmod = Cursor.Position.X - Me.Location.X
        Ymod = Cursor.Position.Y - Me.Location.Y
    End Sub

    Private Sub Coin1GroupBox_MouseMove(sender As Object, e As MouseEventArgs) Handles Coin1GroupBox.MouseMove
        If Me.mouseIsDown Then
            Me.Location = New Point(Cursor.Position.X - Xmod, Cursor.Position.Y - Ymod)
            'Me.Label6.Text = Me.Location.X & "," & Me.Location.Y
            'Debug.Print(Me.Location.X & "," & Me.Location.Y)
        End If
    End Sub

    Private Sub Coin1GroupBox_MouseUp(sender As Object, e As MouseEventArgs) Handles Coin1GroupBox.MouseUp
        Me.mouseIsDown = False
    End Sub

    Private Sub cboCoinFrom_SelectedItemChanged(sender As Object, e As EventArgs) Handles cboCoinFrom.SelectedIndexChanged
        If (Not IsNothing(Me.cboCoinFrom.SelectedItem)) And (Not IsNothing(Me.cboCoinTo.SelectedItem)) Then
            Me.Coin1RefreshTimer.Stop()
            Me.Coin1SnapTimer.Stop()
            Me.coin1HighestPrice = 0.0
            Me.Form1_Load(New Object, New EventArgs)
        End If
    End Sub

    Private Sub cboCoinTo_SelectedItemChanged(sender As Object, e As EventArgs) Handles cboCoinTo.SelectedIndexChanged
        If (Not IsNothing(Me.cboCoinFrom.SelectedItem)) And (Not IsNothing(Me.cboCoinTo.SelectedItem)) Then
            Me.Coin1RefreshTimer.Stop()
            Me.Coin1SnapTimer.Stop()
            Me.coin1HighestPrice = 0.0
            Me.Form1_Load(New Object, New EventArgs)
        End If
    End Sub
End Class
