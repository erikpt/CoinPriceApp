<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Coin1RefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Coin1GroupBox = New System.Windows.Forms.GroupBox()
        Me.cboCoinTo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboCoinFrom = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Coin1PriceDelta = New System.Windows.Forms.Label()
        Me.Coin1Vol24 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Coin1LastUpdate = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Coin1LowDay = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Coin1HighDay = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Coin1OpenDay = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Coin1Low24 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Coin1High24 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Coin1Open24 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Coin1Price = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Coin1SnapTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Coin1Exchange = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Coin1GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Coin1RefreshTimer
        '
        '
        'Coin1GroupBox
        '
        Me.Coin1GroupBox.BackColor = System.Drawing.Color.Black
        Me.Coin1GroupBox.Controls.Add(Me.Coin1Exchange)
        Me.Coin1GroupBox.Controls.Add(Me.Label14)
        Me.Coin1GroupBox.Controls.Add(Me.cboCoinTo)
        Me.Coin1GroupBox.Controls.Add(Me.Label6)
        Me.Coin1GroupBox.Controls.Add(Me.cboCoinFrom)
        Me.Coin1GroupBox.Controls.Add(Me.Label12)
        Me.Coin1GroupBox.Controls.Add(Me.Coin1PriceDelta)
        Me.Coin1GroupBox.Controls.Add(Me.Coin1Vol24)
        Me.Coin1GroupBox.Controls.Add(Me.Label11)
        Me.Coin1GroupBox.Controls.Add(Me.Coin1LastUpdate)
        Me.Coin1GroupBox.Controls.Add(Me.Label9)
        Me.Coin1GroupBox.Controls.Add(Me.Label2)
        Me.Coin1GroupBox.Controls.Add(Me.Coin1LowDay)
        Me.Coin1GroupBox.Controls.Add(Me.Label4)
        Me.Coin1GroupBox.Controls.Add(Me.Coin1HighDay)
        Me.Coin1GroupBox.Controls.Add(Me.Label8)
        Me.Coin1GroupBox.Controls.Add(Me.Coin1OpenDay)
        Me.Coin1GroupBox.Controls.Add(Me.Label10)
        Me.Coin1GroupBox.Controls.Add(Me.Coin1Low24)
        Me.Coin1GroupBox.Controls.Add(Me.Label7)
        Me.Coin1GroupBox.Controls.Add(Me.Coin1High24)
        Me.Coin1GroupBox.Controls.Add(Me.Label5)
        Me.Coin1GroupBox.Controls.Add(Me.Coin1Open24)
        Me.Coin1GroupBox.Controls.Add(Me.Label3)
        Me.Coin1GroupBox.Controls.Add(Me.Coin1Price)
        Me.Coin1GroupBox.Controls.Add(Me.Label1)
        Me.Coin1GroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Coin1GroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coin1GroupBox.ForeColor = System.Drawing.Color.White
        Me.Coin1GroupBox.Location = New System.Drawing.Point(0, 0)
        Me.Coin1GroupBox.Name = "Coin1GroupBox"
        Me.Coin1GroupBox.Size = New System.Drawing.Size(750, 250)
        Me.Coin1GroupBox.TabIndex = 2
        Me.Coin1GroupBox.TabStop = False
        Me.Coin1GroupBox.Text = "IOT/USD Status"
        '
        'cboCoinTo
        '
        Me.cboCoinTo.BackColor = System.Drawing.Color.Black
        Me.cboCoinTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCoinTo.ForeColor = System.Drawing.Color.White
        Me.cboCoinTo.FormattingEnabled = True
        Me.cboCoinTo.Items.AddRange(New Object() {"USD", "BTC", "ETH", "AUD", "CAD", "EUR", "JPY", "RUB", "CHF", "GBP", "CNY"})
        Me.cboCoinTo.Location = New System.Drawing.Point(284, 22)
        Me.cboCoinTo.Name = "cboCoinTo"
        Me.cboCoinTo.Size = New System.Drawing.Size(80, 24)
        Me.cboCoinTo.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(257, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 23)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "/"
        '
        'cboCoinFrom
        '
        Me.cboCoinFrom.BackColor = System.Drawing.Color.Black
        Me.cboCoinFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCoinFrom.ForeColor = System.Drawing.Color.White
        Me.cboCoinFrom.FormattingEnabled = True
        Me.cboCoinFrom.Items.AddRange(New Object() {"IOT", "BTC", "ETH", "LTC", "BCH", "GNO", "EOS", "LSK", "DASH", "ICN", "FCT", "XMR", "NAV", "MAID", "REP", "XRP", "BCU", "AVT", "ETP", "OMG", "SAN", "DAT", "NEO", "DOGE", "QTUM", "ZEN", "LBC"})
        Me.cboCoinFrom.Location = New System.Drawing.Point(171, 22)
        Me.cboCoinFrom.Name = "cboCoinFrom"
        Me.cboCoinFrom.Size = New System.Drawing.Size(80, 24)
        Me.cboCoinFrom.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(385, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 23)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Change:"
        '
        'Coin1PriceDelta
        '
        Me.Coin1PriceDelta.AutoSize = True
        Me.Coin1PriceDelta.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.Coin1PriceDelta.ForeColor = System.Drawing.Color.White
        Me.Coin1PriceDelta.Location = New System.Drawing.Point(478, 59)
        Me.Coin1PriceDelta.Name = "Coin1PriceDelta"
        Me.Coin1PriceDelta.Size = New System.Drawing.Size(116, 28)
        Me.Coin1PriceDelta.TabIndex = 19
        Me.Coin1PriceDelta.Text = "        "
        Me.Coin1PriceDelta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Coin1Vol24
        '
        Me.Coin1Vol24.AutoSize = True
        Me.Coin1Vol24.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coin1Vol24.ForeColor = System.Drawing.Color.White
        Me.Coin1Vol24.Location = New System.Drawing.Point(544, 201)
        Me.Coin1Vol24.Name = "Coin1Vol24"
        Me.Coin1Vol24.Size = New System.Drawing.Size(65, 23)
        Me.Coin1Vol24.TabIndex = 18
        Me.Coin1Vol24.Text = "     "
        Me.Coin1Vol24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(385, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 23)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Volume (24h):"
        '
        'Coin1LastUpdate
        '
        Me.Coin1LastUpdate.AutoSize = True
        Me.Coin1LastUpdate.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coin1LastUpdate.ForeColor = System.Drawing.Color.White
        Me.Coin1LastUpdate.Location = New System.Drawing.Point(153, 201)
        Me.Coin1LastUpdate.Name = "Coin1LastUpdate"
        Me.Coin1LastUpdate.Size = New System.Drawing.Size(98, 23)
        Me.Coin1LastUpdate.TabIndex = 16
        Me.Coin1LastUpdate.Text = "        "
        Me.Coin1LastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(7, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 23)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Last Update:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(724, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "X"
        '
        'Coin1LowDay
        '
        Me.Coin1LowDay.AutoSize = True
        Me.Coin1LowDay.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coin1LowDay.ForeColor = System.Drawing.Color.White
        Me.Coin1LowDay.Location = New System.Drawing.Point(511, 139)
        Me.Coin1LowDay.Name = "Coin1LowDay"
        Me.Coin1LowDay.Size = New System.Drawing.Size(98, 23)
        Me.Coin1LowDay.TabIndex = 13
        Me.Coin1LowDay.Text = "        "
        Me.Coin1LowDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(385, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Low (day):"
        '
        'Coin1HighDay
        '
        Me.Coin1HighDay.AutoSize = True
        Me.Coin1HighDay.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coin1HighDay.ForeColor = System.Drawing.Color.White
        Me.Coin1HighDay.Location = New System.Drawing.Point(522, 116)
        Me.Coin1HighDay.Name = "Coin1HighDay"
        Me.Coin1HighDay.Size = New System.Drawing.Size(98, 23)
        Me.Coin1HighDay.TabIndex = 11
        Me.Coin1HighDay.Text = "        "
        Me.Coin1HighDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(385, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 23)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "High (day):"
        '
        'Coin1OpenDay
        '
        Me.Coin1OpenDay.AutoSize = True
        Me.Coin1OpenDay.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coin1OpenDay.ForeColor = System.Drawing.Color.White
        Me.Coin1OpenDay.Location = New System.Drawing.Point(522, 93)
        Me.Coin1OpenDay.Name = "Coin1OpenDay"
        Me.Coin1OpenDay.Size = New System.Drawing.Size(98, 23)
        Me.Coin1OpenDay.TabIndex = 9
        Me.Coin1OpenDay.Text = "        "
        Me.Coin1OpenDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(385, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 23)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Open (day):"
        '
        'Coin1Low24
        '
        Me.Coin1Low24.AutoSize = True
        Me.Coin1Low24.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coin1Low24.ForeColor = System.Drawing.Color.White
        Me.Coin1Low24.Location = New System.Drawing.Point(133, 139)
        Me.Coin1Low24.Name = "Coin1Low24"
        Me.Coin1Low24.Size = New System.Drawing.Size(98, 23)
        Me.Coin1Low24.TabIndex = 7
        Me.Coin1Low24.Text = "        "
        Me.Coin1Low24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Low (24h):"
        '
        'Coin1High24
        '
        Me.Coin1High24.AutoSize = True
        Me.Coin1High24.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coin1High24.ForeColor = System.Drawing.Color.White
        Me.Coin1High24.Location = New System.Drawing.Point(144, 116)
        Me.Coin1High24.Name = "Coin1High24"
        Me.Coin1High24.Size = New System.Drawing.Size(98, 23)
        Me.Coin1High24.TabIndex = 5
        Me.Coin1High24.Text = "        "
        Me.Coin1High24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "High (24h):"
        '
        'Coin1Open24
        '
        Me.Coin1Open24.AutoSize = True
        Me.Coin1Open24.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coin1Open24.ForeColor = System.Drawing.Color.White
        Me.Coin1Open24.Location = New System.Drawing.Point(144, 93)
        Me.Coin1Open24.Name = "Coin1Open24"
        Me.Coin1Open24.Size = New System.Drawing.Size(98, 23)
        Me.Coin1Open24.TabIndex = 3
        Me.Coin1Open24.Text = "        "
        Me.Coin1Open24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Open (24h):"
        '
        'Coin1Price
        '
        Me.Coin1Price.AutoSize = True
        Me.Coin1Price.Font = New System.Drawing.Font("Consolas", 20.0!)
        Me.Coin1Price.ForeColor = System.Drawing.Color.White
        Me.Coin1Price.Location = New System.Drawing.Point(151, 50)
        Me.Coin1Price.Name = "Coin1Price"
        Me.Coin1Price.Size = New System.Drawing.Size(169, 40)
        Me.Coin1Price.TabIndex = 1
        Me.Coin1Price.Text = "        "
        Me.Coin1Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Price (USD): "
        '
        'Coin1SnapTimer
        '
        Me.Coin1SnapTimer.Interval = 30000
        '
        'Coin1Exchange
        '
        Me.Coin1Exchange.AutoSize = True
        Me.Coin1Exchange.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coin1Exchange.ForeColor = System.Drawing.Color.White
        Me.Coin1Exchange.Location = New System.Drawing.Point(122, 178)
        Me.Coin1Exchange.Name = "Coin1Exchange"
        Me.Coin1Exchange.Size = New System.Drawing.Size(98, 23)
        Me.Coin1Exchange.TabIndex = 25
        Me.Coin1Exchange.Text = "        "
        Me.Coin1Exchange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(7, 178)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 23)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Exchange:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.Coin1GroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "IOT/USD Status"
        Me.Coin1GroupBox.ResumeLayout(False)
        Me.Coin1GroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Coin1RefreshTimer As System.Windows.Forms.Timer
    Friend WithEvents Coin1GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Coin1Price As System.Windows.Forms.Label
    Friend WithEvents Coin1Low24 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Coin1High24 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Coin1Open24 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Coin1LowDay As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Coin1HighDay As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Coin1OpenDay As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Coin1SnapTimer As System.Windows.Forms.Timer
    Friend WithEvents Coin1LastUpdate As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Coin1Vol24 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Coin1PriceDelta As System.Windows.Forms.Label
    Friend WithEvents cboCoinTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboCoinFrom As System.Windows.Forms.ComboBox
    Friend WithEvents Coin1Exchange As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label

End Class
