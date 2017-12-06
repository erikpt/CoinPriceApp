Public Class Form1

    Private api As CryptoCompareMinAPI
    Private coin1Snapshot As CryptoCompareMinAPI.CoinSnapshot
    Private coin1LastPrice As Double
    Private mouseIsDown As Boolean = False
    Private Xmod As Long = 0
    Private Ymod As Long = 0

    Function ConvertUnixDate(unixdate As Long) As DateTime
        Dim dt As New DateTime(1970, 1, 1)
        Return dt.AddSeconds(unixdate)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        coin1Snapshot = api.GetSnapshotIOTUSD
        Me.Coin1GroupBox.Text = coin1Snapshot.Data.AggregatedData.FROMSYMBOL & "/" & coin1Snapshot.Data.AggregatedData.TOSYMBOL
        Me.coin1LastPrice = coin1Snapshot.Data.AggregatedData.PRICE
        Me.Text = Coin1GroupBox.Text & "Current Price: " & Me.coin1LastPrice.ToString("$0.00")
        Dim lud As DateTime = ConvertUnixDate(coin1Snapshot.Data.AggregatedData.LASTUPDATE).ToLocalTime
        Me.Coin1Vol24.Text = coin1Snapshot.Data.AggregatedData.VOLUME24HOUR.ToString("0.000")
        Me.Coin1LastUpdate.Text = lud.ToShortDateString & " " & lud.ToShortTimeString
        Me.Coin1Open24.Text = coin1Snapshot.Data.AggregatedData.OPEN24HOUR.ToString("$0.00")
        Me.Coin1High24.Text = coin1Snapshot.Data.AggregatedData.HIGH24HOUR.ToString("$0.00")
        Me.Coin1Low24.Text = coin1Snapshot.Data.AggregatedData.LOW24HOUR.ToString("$0.00")
        Me.Coin1OpenDay.Text = coin1Snapshot.Data.AggregatedData.OPENDAY.ToString("$0.00")
        Me.Coin1LowDay.Text = coin1Snapshot.Data.AggregatedData.LOWDAY.ToString("$0.00")
        Me.Coin1HighDay.Text = coin1Snapshot.Data.AggregatedData.HIGHDAY.ToString("$0.00")
        If Me.Coin1RefreshTimer.Enabled Then
            Me.Coin1RefreshTimer.Enabled = False
        Else
            Me.Coin1RefreshTimer.Enabled = True
        End If
    End Sub

    Private Sub Coin1RefreshTimer_Tick(sender As Object, e As EventArgs) Handles Coin1RefreshTimer.Tick
        Dim info As CryptoCompareMinAPI.PriceInfo = api.GetPriceIOTUSD
        Dim open As Double = coin1Snapshot.Data.AggregatedData.OPEN24HOUR
        Dim gainLossAmt As Double = info.USD - open
        Dim gainLossPct As Double = Math.Abs(gainLossAmt) / open
        Me.Coin1Price.Text = info.USD.ToString("$0.00")
        If info.USD > open Then
            Me.Coin1Price.ForeColor = Color.LightGreen
            Me.Coin1PriceDelta.ForeColor = Color.LightGreen
            Me.Coin1PriceDelta.Text = "(+" & gainLossAmt.ToString("$0.00") & " +" & gainLossPct.ToString("0.00%") & ")"
        ElseIf info.USD < coin1Snapshot.Data.AggregatedData.OPEN24HOUR Then
            Me.Coin1Price.ForeColor = Color.Red
            Me.Coin1PriceDelta.ForeColor = Color.Red
            Me.Coin1PriceDelta.Text = "(" & gainLossAmt.ToString("$0.00") & " -" & gainLossPct.ToString("0.00%") & ")"
        Else
            Me.Coin1Price.ForeColor = Color.Yellow
            Me.Coin1PriceDelta.ForeColor = Color.Yellow
            Me.Coin1PriceDelta.Text = "(" & gainLossAmt.ToString("$0.00") & " " & gainLossPct.ToString("0.00%") & ")"
        End If
        If info.USD > coin1LastPrice Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        ElseIf info.USD < coin1LastPrice Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
        End If
        coin1LastPrice = info.USD

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        api = New CryptoCompareMinAPI
        Button1_Click(New Object, New EventArgs)
        Me.Coin1SnapTimer.Enabled = True
        Me.Coin1GroupBox.Cursor = Cursors.Cross
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
End Class
