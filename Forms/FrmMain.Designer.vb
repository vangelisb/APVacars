<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PilotInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlightInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeatherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlightSimulatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResendReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.FsUipcStatuslbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimeToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLblPilotId = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gbRTFI = New System.Windows.Forms.GroupBox()
        Me.lblFlightNumber = New System.Windows.Forms.Label()
        Me.lblFlightNumberTag = New System.Windows.Forms.Label()
        Me.lblArrival = New System.Windows.Forms.Label()
        Me.lblArrivalTag = New System.Windows.Forms.Label()
        Me.lblDeparture = New System.Windows.Forms.Label()
        Me.lblDepartureTag = New System.Windows.Forms.Label()
        Me.lblFlightTime = New System.Windows.Forms.Label()
        Me.lblFlightTimeTag = New System.Windows.Forms.Label()
        Me.lblfuel = New System.Windows.Forms.Label()
        Me.lblTAS = New System.Windows.Forms.Label()
        Me.lblHdg = New System.Windows.Forms.Label()
        Me.lblAlt = New System.Windows.Forms.Label()
        Me.lblFuelTag = New System.Windows.Forms.Label()
        Me.lblTASTag = New System.Windows.Forms.Label()
        Me.lblHdgTag = New System.Windows.Forms.Label()
        Me.lblAltTag = New System.Windows.Forms.Label()
        Me.RtbLog = New System.Windows.Forms.RichTextBox()
        Me.BtnGetFlight = New System.Windows.Forms.Button()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.btnSendLog = New System.Windows.Forms.Button()
        Me.TmrAcars = New System.Windows.Forms.Timer(Me.components)
        Me.chkrecgear = New System.Windows.Forms.CheckBox()
        Me.chkonground = New System.Windows.Forms.CheckBox()
        Me.chkoverspeed = New System.Windows.Forms.CheckBox()
        Me.chkstall = New System.Windows.Forms.CheckBox()
        Me.chkgear = New System.Windows.Forms.CheckBox()
        Me.chkbrakes = New System.Windows.Forms.CheckBox()
        Me.chklandinglightoffbellowfl100 = New System.Windows.Forms.CheckBox()
        Me.chklandinglightonafl100 = New System.Windows.Forms.CheckBox()
        Me.chklandinglights = New System.Windows.Forms.CheckBox()
        Me.btnStopLog = New System.Windows.Forms.Button()
        Me.tmrWriteReadLog = New System.Windows.Forms.Timer(Me.components)
        Me.TmrGetDataFromFs = New System.Windows.Forms.Timer(Me.components)
        Me.tmrtime = New System.Windows.Forms.Timer(Me.components)
        Me.txtsimrate = New System.Windows.Forms.TextBox()
        Me.chkpause = New System.Windows.Forms.CheckBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.gbRTFI.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.FlightInformationToolStripMenuItem, Me.WeatherToolStripMenuItem, Me.FlightSimulatorToolStripMenuItem, Me.ResendReportsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(593, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PilotInfoToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'PilotInfoToolStripMenuItem
        '
        Me.PilotInfoToolStripMenuItem.Name = "PilotInfoToolStripMenuItem"
        Me.PilotInfoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PilotInfoToolStripMenuItem.Text = "Pilot Info"
        '
        'FlightInformationToolStripMenuItem
        '
        Me.FlightInformationToolStripMenuItem.Name = "FlightInformationToolStripMenuItem"
        Me.FlightInformationToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.FlightInformationToolStripMenuItem.Text = "Flight Information"
        '
        'WeatherToolStripMenuItem
        '
        Me.WeatherToolStripMenuItem.Name = "WeatherToolStripMenuItem"
        Me.WeatherToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.WeatherToolStripMenuItem.Text = "Weather"
        '
        'FlightSimulatorToolStripMenuItem
        '
        Me.FlightSimulatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectToolStripMenuItem, Me.DisconnectToolStripMenuItem})
        Me.FlightSimulatorToolStripMenuItem.Name = "FlightSimulatorToolStripMenuItem"
        Me.FlightSimulatorToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.FlightSimulatorToolStripMenuItem.Text = "Flight Simulator"
        '
        'ConnectToolStripMenuItem
        '
        Me.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem"
        Me.ConnectToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ConnectToolStripMenuItem.Text = "Connect"
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
        Me.DisconnectToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.DisconnectToolStripMenuItem.Text = "Disconnect"
        '
        'ResendReportsToolStripMenuItem
        '
        Me.ResendReportsToolStripMenuItem.Name = "ResendReportsToolStripMenuItem"
        Me.ResendReportsToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.ResendReportsToolStripMenuItem.Text = "Resend Reports"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FsUipcStatuslbl, Me.LblTime, Me.TimeToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.StatusLblPilotId})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 417)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(593, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'FsUipcStatuslbl
        '
        Me.FsUipcStatuslbl.Name = "FsUipcStatuslbl"
        Me.FsUipcStatuslbl.Size = New System.Drawing.Size(0, 17)
        '
        'LblTime
        '
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(29, 17)
        Me.LblTime.Text = "Time"
        '
        'TimeToolStripStatusLabel1
        '
        Me.TimeToolStripStatusLabel1.Name = "TimeToolStripStatusLabel1"
        Me.TimeToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(48, 17)
        Me.ToolStripStatusLabel2.Text = "Pilot ID :"
        '
        'StatusLblPilotId
        '
        Me.StatusLblPilotId.Name = "StatusLblPilotId"
        Me.StatusLblPilotId.Size = New System.Drawing.Size(37, 17)
        Me.StatusLblPilotId.Text = "PilotId"
        '
        'gbRTFI
        '
        Me.gbRTFI.Controls.Add(Me.lblFlightNumber)
        Me.gbRTFI.Controls.Add(Me.lblFlightNumberTag)
        Me.gbRTFI.Controls.Add(Me.lblArrival)
        Me.gbRTFI.Controls.Add(Me.lblArrivalTag)
        Me.gbRTFI.Controls.Add(Me.lblDeparture)
        Me.gbRTFI.Controls.Add(Me.lblDepartureTag)
        Me.gbRTFI.Controls.Add(Me.lblFlightTime)
        Me.gbRTFI.Controls.Add(Me.lblFlightTimeTag)
        Me.gbRTFI.Controls.Add(Me.lblfuel)
        Me.gbRTFI.Controls.Add(Me.lblTAS)
        Me.gbRTFI.Controls.Add(Me.lblHdg)
        Me.gbRTFI.Controls.Add(Me.lblAlt)
        Me.gbRTFI.Controls.Add(Me.lblFuelTag)
        Me.gbRTFI.Controls.Add(Me.lblTASTag)
        Me.gbRTFI.Controls.Add(Me.lblHdgTag)
        Me.gbRTFI.Controls.Add(Me.lblAltTag)
        Me.gbRTFI.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gbRTFI.Location = New System.Drawing.Point(82, 27)
        Me.gbRTFI.Name = "gbRTFI"
        Me.gbRTFI.Size = New System.Drawing.Size(509, 72)
        Me.gbRTFI.TabIndex = 5
        Me.gbRTFI.TabStop = False
        Me.gbRTFI.Text = "Real-Time Flight Information"
        '
        'lblFlightNumber
        '
        Me.lblFlightNumber.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblFlightNumber.Location = New System.Drawing.Point(90, 47)
        Me.lblFlightNumber.Name = "lblFlightNumber"
        Me.lblFlightNumber.Size = New System.Drawing.Size(73, 16)
        Me.lblFlightNumber.TabIndex = 23
        '
        'lblFlightNumberTag
        '
        Me.lblFlightNumberTag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblFlightNumberTag.Location = New System.Drawing.Point(6, 47)
        Me.lblFlightNumberTag.Name = "lblFlightNumberTag"
        Me.lblFlightNumberTag.Size = New System.Drawing.Size(78, 22)
        Me.lblFlightNumberTag.TabIndex = 22
        Me.lblFlightNumberTag.Text = "Flight Number:"
        '
        'lblArrival
        '
        Me.lblArrival.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblArrival.Location = New System.Drawing.Point(405, 47)
        Me.lblArrival.Name = "lblArrival"
        Me.lblArrival.Size = New System.Drawing.Size(48, 16)
        Me.lblArrival.TabIndex = 21
        '
        'lblArrivalTag
        '
        Me.lblArrivalTag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblArrivalTag.Location = New System.Drawing.Point(314, 47)
        Me.lblArrivalTag.Name = "lblArrivalTag"
        Me.lblArrivalTag.Size = New System.Drawing.Size(85, 16)
        Me.lblArrivalTag.TabIndex = 20
        Me.lblArrivalTag.Text = "Arrival Aiport:"
        '
        'lblDeparture
        '
        Me.lblDeparture.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDeparture.Location = New System.Drawing.Point(261, 47)
        Me.lblDeparture.Name = "lblDeparture"
        Me.lblDeparture.Size = New System.Drawing.Size(48, 16)
        Me.lblDeparture.TabIndex = 19
        '
        'lblDepartureTag
        '
        Me.lblDepartureTag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblDepartureTag.Location = New System.Drawing.Point(169, 47)
        Me.lblDepartureTag.Name = "lblDepartureTag"
        Me.lblDepartureTag.Size = New System.Drawing.Size(103, 22)
        Me.lblDepartureTag.TabIndex = 18
        Me.lblDepartureTag.Text = "Departure Aiport:"
        '
        'lblFlightTime
        '
        Me.lblFlightTime.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblFlightTime.Location = New System.Drawing.Point(448, 16)
        Me.lblFlightTime.Name = "lblFlightTime"
        Me.lblFlightTime.Size = New System.Drawing.Size(56, 15)
        Me.lblFlightTime.TabIndex = 17
        '
        'lblFlightTimeTag
        '
        Me.lblFlightTimeTag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblFlightTimeTag.Location = New System.Drawing.Point(383, 16)
        Me.lblFlightTimeTag.Name = "lblFlightTimeTag"
        Me.lblFlightTimeTag.Size = New System.Drawing.Size(70, 16)
        Me.lblFlightTimeTag.TabIndex = 16
        Me.lblFlightTimeTag.Text = "Flight Time :"
        '
        'lblfuel
        '
        Me.lblfuel.AccessibleDescription = ""
        Me.lblfuel.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblfuel.Location = New System.Drawing.Point(299, 16)
        Me.lblfuel.Name = "lblfuel"
        Me.lblfuel.Size = New System.Drawing.Size(80, 16)
        Me.lblfuel.TabIndex = 15
        '
        'lblTAS
        '
        Me.lblTAS.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblTAS.Location = New System.Drawing.Point(207, 16)
        Me.lblTAS.Name = "lblTAS"
        Me.lblTAS.Size = New System.Drawing.Size(48, 16)
        Me.lblTAS.TabIndex = 10
        '
        'lblHdg
        '
        Me.lblHdg.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblHdg.Location = New System.Drawing.Point(128, 16)
        Me.lblHdg.Name = "lblHdg"
        Me.lblHdg.Size = New System.Drawing.Size(35, 16)
        Me.lblHdg.TabIndex = 9
        '
        'lblAlt
        '
        Me.lblAlt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblAlt.Location = New System.Drawing.Point(36, 16)
        Me.lblAlt.Name = "lblAlt"
        Me.lblAlt.Size = New System.Drawing.Size(48, 16)
        Me.lblAlt.TabIndex = 8
        '
        'lblFuelTag
        '
        Me.lblFuelTag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblFuelTag.Location = New System.Drawing.Point(261, 16)
        Me.lblFuelTag.Name = "lblFuelTag"
        Me.lblFuelTag.Size = New System.Drawing.Size(32, 16)
        Me.lblFuelTag.TabIndex = 7
        Me.lblFuelTag.Text = "Fuel:"
        '
        'lblTASTag
        '
        Me.lblTASTag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblTASTag.Location = New System.Drawing.Point(169, 16)
        Me.lblTASTag.Name = "lblTASTag"
        Me.lblTASTag.Size = New System.Drawing.Size(32, 16)
        Me.lblTASTag.TabIndex = 2
        Me.lblTASTag.Text = "IAS:"
        '
        'lblHdgTag
        '
        Me.lblHdgTag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblHdgTag.Location = New System.Drawing.Point(90, 17)
        Me.lblHdgTag.Name = "lblHdgTag"
        Me.lblHdgTag.Size = New System.Drawing.Size(32, 16)
        Me.lblHdgTag.TabIndex = 1
        Me.lblHdgTag.Text = "Hdg:"
        '
        'lblAltTag
        '
        Me.lblAltTag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblAltTag.Location = New System.Drawing.Point(6, 16)
        Me.lblAltTag.Name = "lblAltTag"
        Me.lblAltTag.Size = New System.Drawing.Size(24, 16)
        Me.lblAltTag.TabIndex = 0
        Me.lblAltTag.Text = "Alt:"
        '
        'RtbLog
        '
        Me.RtbLog.Cursor = System.Windows.Forms.Cursors.Default
        Me.RtbLog.Location = New System.Drawing.Point(0, 105)
        Me.RtbLog.Name = "RtbLog"
        Me.RtbLog.ReadOnly = True
        Me.RtbLog.Size = New System.Drawing.Size(591, 309)
        Me.RtbLog.TabIndex = 6
        Me.RtbLog.Text = ""
        '
        'BtnGetFlight
        '
        Me.BtnGetFlight.Location = New System.Drawing.Point(0, 27)
        Me.BtnGetFlight.Name = "BtnGetFlight"
        Me.BtnGetFlight.Size = New System.Drawing.Size(76, 23)
        Me.BtnGetFlight.TabIndex = 7
        Me.BtnGetFlight.Text = "Get Flight"
        Me.BtnGetFlight.UseVisualStyleBackColor = True
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(0, 51)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(76, 23)
        Me.BtnStart.TabIndex = 8
        Me.BtnStart.Text = "Start Log"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'btnSendLog
        '
        Me.btnSendLog.Location = New System.Drawing.Point(1, 74)
        Me.btnSendLog.Name = "btnSendLog"
        Me.btnSendLog.Size = New System.Drawing.Size(75, 23)
        Me.btnSendLog.TabIndex = 9
        Me.btnSendLog.Text = "Send Log"
        Me.btnSendLog.UseVisualStyleBackColor = True
        '
        'TmrAcars
        '
        Me.TmrAcars.Interval = 5000
        '
        'chkrecgear
        '
        Me.chkrecgear.AutoSize = True
        Me.chkrecgear.Location = New System.Drawing.Point(345, 269)
        Me.chkrecgear.Name = "chkrecgear"
        Me.chkrecgear.Size = New System.Drawing.Size(107, 17)
        Me.chkrecgear.TabIndex = 76
        Me.chkrecgear.Text = "Retractable Gear"
        Me.chkrecgear.UseVisualStyleBackColor = True
        '
        'chkonground
        '
        Me.chkonground.AutoSize = True
        Me.chkonground.Location = New System.Drawing.Point(345, 246)
        Me.chkonground.Name = "chkonground"
        Me.chkonground.Size = New System.Drawing.Size(93, 17)
        Me.chkonground.TabIndex = 75
        Me.chkonground.Text = "AC on Ground"
        Me.chkonground.UseVisualStyleBackColor = True
        '
        'chkoverspeed
        '
        Me.chkoverspeed.AutoSize = True
        Me.chkoverspeed.Location = New System.Drawing.Point(345, 223)
        Me.chkoverspeed.Name = "chkoverspeed"
        Me.chkoverspeed.Size = New System.Drawing.Size(78, 17)
        Me.chkoverspeed.TabIndex = 74
        Me.chkoverspeed.Text = "Overspeed"
        Me.chkoverspeed.UseVisualStyleBackColor = True
        '
        'chkstall
        '
        Me.chkstall.AutoSize = True
        Me.chkstall.Location = New System.Drawing.Point(345, 200)
        Me.chkstall.Name = "chkstall"
        Me.chkstall.Size = New System.Drawing.Size(46, 17)
        Me.chkstall.TabIndex = 73
        Me.chkstall.Text = "Stall"
        Me.chkstall.UseVisualStyleBackColor = True
        '
        'chkgear
        '
        Me.chkgear.AutoSize = True
        Me.chkgear.Location = New System.Drawing.Point(345, 180)
        Me.chkgear.Name = "chkgear"
        Me.chkgear.Size = New System.Drawing.Size(49, 17)
        Me.chkgear.TabIndex = 72
        Me.chkgear.Text = "Gear"
        Me.chkgear.UseVisualStyleBackColor = True
        '
        'chkbrakes
        '
        Me.chkbrakes.AutoSize = True
        Me.chkbrakes.Location = New System.Drawing.Point(345, 158)
        Me.chkbrakes.Name = "chkbrakes"
        Me.chkbrakes.Size = New System.Drawing.Size(59, 17)
        Me.chkbrakes.TabIndex = 71
        Me.chkbrakes.Text = "Breaks"
        Me.chkbrakes.UseVisualStyleBackColor = True
        '
        'chklandinglightoffbellowfl100
        '
        Me.chklandinglightoffbellowfl100.AutoSize = True
        Me.chklandinglightoffbellowfl100.Location = New System.Drawing.Point(151, 191)
        Me.chklandinglightoffbellowfl100.Name = "chklandinglightoffbellowfl100"
        Me.chklandinglightoffbellowfl100.Size = New System.Drawing.Size(175, 17)
        Me.chklandinglightoffbellowfl100.TabIndex = 79
        Me.chklandinglightoffbellowfl100.Text = "Landing Lights off Below FL100"
        Me.chklandinglightoffbellowfl100.UseVisualStyleBackColor = True
        '
        'chklandinglightonafl100
        '
        Me.chklandinglightonafl100.AutoSize = True
        Me.chklandinglightonafl100.Location = New System.Drawing.Point(151, 170)
        Me.chklandinglightonafl100.Name = "chklandinglightonafl100"
        Me.chklandinglightonafl100.Size = New System.Drawing.Size(177, 17)
        Me.chklandinglightonafl100.TabIndex = 78
        Me.chklandinglightonafl100.Text = "Landing Lights on Above FL100"
        Me.chklandinglightonafl100.UseVisualStyleBackColor = True
        '
        'chklandinglights
        '
        Me.chklandinglights.AutoSize = True
        Me.chklandinglights.Location = New System.Drawing.Point(151, 153)
        Me.chklandinglights.Name = "chklandinglights"
        Me.chklandinglights.Size = New System.Drawing.Size(95, 17)
        Me.chklandinglights.TabIndex = 77
        Me.chklandinglights.Text = "Landing Lights"
        Me.chklandinglights.UseVisualStyleBackColor = True
        '
        'btnStopLog
        '
        Me.btnStopLog.Location = New System.Drawing.Point(0, 50)
        Me.btnStopLog.Name = "btnStopLog"
        Me.btnStopLog.Size = New System.Drawing.Size(76, 23)
        Me.btnStopLog.TabIndex = 80
        Me.btnStopLog.Text = "Stop Log"
        Me.btnStopLog.UseVisualStyleBackColor = True
        Me.btnStopLog.Visible = False
        '
        'tmrWriteReadLog
        '
        '
        'TmrGetDataFromFs
        '
        Me.TmrGetDataFromFs.Enabled = True
        '
        'tmrtime
        '
        Me.tmrtime.Enabled = True
        '
        'txtsimrate
        '
        Me.txtsimrate.Location = New System.Drawing.Point(151, 220)
        Me.txtsimrate.Name = "txtsimrate"
        Me.txtsimrate.Size = New System.Drawing.Size(100, 20)
        Me.txtsimrate.TabIndex = 84
        '
        'chkpause
        '
        Me.chkpause.AutoSize = True
        Me.chkpause.Location = New System.Drawing.Point(151, 247)
        Me.chkpause.Name = "chkpause"
        Me.chkpause.Size = New System.Drawing.Size(76, 17)
        Me.chkpause.TabIndex = 85
        Me.chkpause.Text = "Pause flag"
        Me.chkpause.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(345, 416)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(232, 23)
        Me.ProgressBar1.TabIndex = 86
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.Location = New System.Drawing.Point(346, 421)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(0, 13)
        Me.lblerror.TabIndex = 87
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 439)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnSendLog)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.BtnGetFlight)
        Me.Controls.Add(Me.RtbLog)
        Me.Controls.Add(Me.gbRTFI)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.chkrecgear)
        Me.Controls.Add(Me.chkonground)
        Me.Controls.Add(Me.chkoverspeed)
        Me.Controls.Add(Me.chkstall)
        Me.Controls.Add(Me.chkgear)
        Me.Controls.Add(Me.chkbrakes)
        Me.Controls.Add(Me.chklandinglightoffbellowfl100)
        Me.Controls.Add(Me.chklandinglightonafl100)
        Me.Controls.Add(Me.chklandinglights)
        Me.Controls.Add(Me.btnStopLog)
        Me.Controls.Add(Me.txtsimrate)
        Me.Controls.Add(Me.chkpause)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.Text = "APVA - Another PhpVms Acars"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.gbRTFI.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PilotInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents FsUipcStatuslbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FlightSimulatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisconnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents gbRTFI As System.Windows.Forms.GroupBox
    Friend WithEvents lblfuel As System.Windows.Forms.Label
    Friend WithEvents lblTAS As System.Windows.Forms.Label
    Friend WithEvents lblHdg As System.Windows.Forms.Label
    Friend WithEvents lblAlt As System.Windows.Forms.Label
    Friend WithEvents lblFuelTag As System.Windows.Forms.Label
    Friend WithEvents lblTASTag As System.Windows.Forms.Label
    Friend WithEvents lblHdgTag As System.Windows.Forms.Label
    Friend WithEvents lblAltTag As System.Windows.Forms.Label
    Friend WithEvents RtbLog As System.Windows.Forms.RichTextBox
    Friend WithEvents BtnGetFlight As System.Windows.Forms.Button
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents btnSendLog As System.Windows.Forms.Button
    Friend WithEvents TimeToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusLblPilotId As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblFlightTime As System.Windows.Forms.Label
    Friend WithEvents lblFlightTimeTag As System.Windows.Forms.Label
    Friend WithEvents lblDeparture As System.Windows.Forms.Label
    Friend WithEvents lblDepartureTag As System.Windows.Forms.Label
    Friend WithEvents lblArrival As System.Windows.Forms.Label
    Friend WithEvents lblArrivalTag As System.Windows.Forms.Label
    Friend WithEvents lblFlightNumber As System.Windows.Forms.Label
    Friend WithEvents lblFlightNumberTag As System.Windows.Forms.Label
    Friend WithEvents FlightInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TmrAcars As System.Windows.Forms.Timer
    Friend WithEvents chkrecgear As System.Windows.Forms.CheckBox
    Friend WithEvents chkonground As System.Windows.Forms.CheckBox
    Friend WithEvents chkoverspeed As System.Windows.Forms.CheckBox
    Friend WithEvents chkstall As System.Windows.Forms.CheckBox
    Friend WithEvents chkgear As System.Windows.Forms.CheckBox
    Friend WithEvents chkbrakes As System.Windows.Forms.CheckBox
    Friend WithEvents chklandinglightoffbellowfl100 As System.Windows.Forms.CheckBox
    Friend WithEvents chklandinglightonafl100 As System.Windows.Forms.CheckBox
    Friend WithEvents chklandinglights As System.Windows.Forms.CheckBox
    Friend WithEvents btnStopLog As System.Windows.Forms.Button
    Friend WithEvents ResendReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrWriteReadLog As System.Windows.Forms.Timer
    Friend WithEvents TmrGetDataFromFs As System.Windows.Forms.Timer
    Friend WithEvents WeatherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrtime As System.Windows.Forms.Timer
    Friend WithEvents txtsimrate As System.Windows.Forms.TextBox
    Friend WithEvents chkpause As System.Windows.Forms.CheckBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblerror As System.Windows.Forms.Label

End Class
