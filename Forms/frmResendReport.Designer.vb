<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResendReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResendReport))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnReadFile = New System.Windows.Forms.Button()
        Me.lblFlightNumberTag = New System.Windows.Forms.Label()
        Me.lblDepartureTag = New System.Windows.Forms.Label()
        Me.lblArrivalTag = New System.Windows.Forms.Label()
        Me.lblAcRegistrationTag = New System.Windows.Forms.Label()
        Me.lblRouteTag = New System.Windows.Forms.Label()
        Me.lblFlightTimeTag = New System.Windows.Forms.Label()
        Me.lblFuelUsedTag = New System.Windows.Forms.Label()
        Me.lblLogTag = New System.Windows.Forms.Label()
        Me.lblFlightNumber = New System.Windows.Forms.Label()
        Me.lblDeparture = New System.Windows.Forms.Label()
        Me.lblArrival = New System.Windows.Forms.Label()
        Me.lblAcRegistration = New System.Windows.Forms.Label()
        Me.lblRoute = New System.Windows.Forms.Label()
        Me.lblFLightTime = New System.Windows.Forms.Label()
        Me.lblFuelUsed = New System.Windows.Forms.Label()
        Me.lblPilotID = New System.Windows.Forms.Label()
        Me.lblPilotIDTag = New System.Windows.Forms.Label()
        Me.RichtxtboxLog = New System.Windows.Forms.RichTextBox()
        Me.lblaircraftused = New System.Windows.Forms.Label()
        Me.lblaircraftusedtag = New System.Windows.Forms.Label()
        Me.lbllandingrate = New System.Windows.Forms.Label()
        Me.lbllandingratetag = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(451, 20)
        Me.TextBox1.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(501, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search File"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(501, 74)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 3
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Flight Reports|*.xml"
        '
        'btnReadFile
        '
        Me.btnReadFile.Location = New System.Drawing.Point(501, 45)
        Me.btnReadFile.Name = "btnReadFile"
        Me.btnReadFile.Size = New System.Drawing.Size(75, 23)
        Me.btnReadFile.TabIndex = 4
        Me.btnReadFile.Text = "Read File"
        Me.btnReadFile.UseVisualStyleBackColor = True
        '
        'lblFlightNumberTag
        '
        Me.lblFlightNumberTag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblFlightNumberTag.Location = New System.Drawing.Point(12, 79)
        Me.lblFlightNumberTag.Name = "lblFlightNumberTag"
        Me.lblFlightNumberTag.Size = New System.Drawing.Size(78, 22)
        Me.lblFlightNumberTag.TabIndex = 23
        Me.lblFlightNumberTag.Text = "Flight Number:"
        '
        'lblDepartureTag
        '
        Me.lblDepartureTag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblDepartureTag.Location = New System.Drawing.Point(12, 101)
        Me.lblDepartureTag.Name = "lblDepartureTag"
        Me.lblDepartureTag.Size = New System.Drawing.Size(110, 22)
        Me.lblDepartureTag.TabIndex = 24
        Me.lblDepartureTag.Text = "Departure Airport:"
        '
        'lblArrivalTag
        '
        Me.lblArrivalTag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblArrivalTag.Location = New System.Drawing.Point(12, 123)
        Me.lblArrivalTag.Name = "lblArrivalTag"
        Me.lblArrivalTag.Size = New System.Drawing.Size(78, 22)
        Me.lblArrivalTag.TabIndex = 25
        Me.lblArrivalTag.Text = "Arrival Airport:"
        '
        'lblAcRegistrationTag
        '
        Me.lblAcRegistrationTag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblAcRegistrationTag.Location = New System.Drawing.Point(12, 145)
        Me.lblAcRegistrationTag.Name = "lblAcRegistrationTag"
        Me.lblAcRegistrationTag.Size = New System.Drawing.Size(110, 22)
        Me.lblAcRegistrationTag.TabIndex = 26
        Me.lblAcRegistrationTag.Text = "Aircraft Registration:"
        '
        'lblRouteTag
        '
        Me.lblRouteTag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblRouteTag.Location = New System.Drawing.Point(12, 191)
        Me.lblRouteTag.Name = "lblRouteTag"
        Me.lblRouteTag.Size = New System.Drawing.Size(78, 22)
        Me.lblRouteTag.TabIndex = 27
        Me.lblRouteTag.Text = "Route:"
        '
        'lblFlightTimeTag
        '
        Me.lblFlightTimeTag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblFlightTimeTag.Location = New System.Drawing.Point(12, 213)
        Me.lblFlightTimeTag.Name = "lblFlightTimeTag"
        Me.lblFlightTimeTag.Size = New System.Drawing.Size(78, 22)
        Me.lblFlightTimeTag.TabIndex = 28
        Me.lblFlightTimeTag.Text = "Flight Time:"
        '
        'lblFuelUsedTag
        '
        Me.lblFuelUsedTag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblFuelUsedTag.Location = New System.Drawing.Point(12, 235)
        Me.lblFuelUsedTag.Name = "lblFuelUsedTag"
        Me.lblFuelUsedTag.Size = New System.Drawing.Size(78, 22)
        Me.lblFuelUsedTag.TabIndex = 29
        Me.lblFuelUsedTag.Text = "Fuel Used:"
        '
        'lblLogTag
        '
        Me.lblLogTag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblLogTag.Location = New System.Drawing.Point(12, 257)
        Me.lblLogTag.Name = "lblLogTag"
        Me.lblLogTag.Size = New System.Drawing.Size(78, 22)
        Me.lblLogTag.TabIndex = 30
        Me.lblLogTag.Text = "Log:"
        '
        'lblFlightNumber
        '
        Me.lblFlightNumber.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblFlightNumber.Location = New System.Drawing.Point(128, 79)
        Me.lblFlightNumber.Name = "lblFlightNumber"
        Me.lblFlightNumber.Size = New System.Drawing.Size(78, 22)
        Me.lblFlightNumber.TabIndex = 31
        '
        'lblDeparture
        '
        Me.lblDeparture.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblDeparture.Location = New System.Drawing.Point(128, 101)
        Me.lblDeparture.Name = "lblDeparture"
        Me.lblDeparture.Size = New System.Drawing.Size(78, 22)
        Me.lblDeparture.TabIndex = 32
        '
        'lblArrival
        '
        Me.lblArrival.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblArrival.Location = New System.Drawing.Point(128, 123)
        Me.lblArrival.Name = "lblArrival"
        Me.lblArrival.Size = New System.Drawing.Size(78, 22)
        Me.lblArrival.TabIndex = 33
        '
        'lblAcRegistration
        '
        Me.lblAcRegistration.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblAcRegistration.Location = New System.Drawing.Point(128, 145)
        Me.lblAcRegistration.Name = "lblAcRegistration"
        Me.lblAcRegistration.Size = New System.Drawing.Size(78, 22)
        Me.lblAcRegistration.TabIndex = 34
        '
        'lblRoute
        '
        Me.lblRoute.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblRoute.Location = New System.Drawing.Point(128, 191)
        Me.lblRoute.Name = "lblRoute"
        Me.lblRoute.Size = New System.Drawing.Size(78, 22)
        Me.lblRoute.TabIndex = 35
        '
        'lblFLightTime
        '
        Me.lblFLightTime.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblFLightTime.Location = New System.Drawing.Point(128, 213)
        Me.lblFLightTime.Name = "lblFLightTime"
        Me.lblFLightTime.Size = New System.Drawing.Size(78, 22)
        Me.lblFLightTime.TabIndex = 36
        '
        'lblFuelUsed
        '
        Me.lblFuelUsed.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblFuelUsed.Location = New System.Drawing.Point(128, 235)
        Me.lblFuelUsed.Name = "lblFuelUsed"
        Me.lblFuelUsed.Size = New System.Drawing.Size(78, 22)
        Me.lblFuelUsed.TabIndex = 37
        '
        'lblPilotID
        '
        Me.lblPilotID.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblPilotID.Location = New System.Drawing.Point(128, 57)
        Me.lblPilotID.Name = "lblPilotID"
        Me.lblPilotID.Size = New System.Drawing.Size(78, 22)
        Me.lblPilotID.TabIndex = 40
        '
        'lblPilotIDTag
        '
        Me.lblPilotIDTag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblPilotIDTag.Location = New System.Drawing.Point(12, 57)
        Me.lblPilotIDTag.Name = "lblPilotIDTag"
        Me.lblPilotIDTag.Size = New System.Drawing.Size(78, 22)
        Me.lblPilotIDTag.TabIndex = 39
        Me.lblPilotIDTag.Text = "Pilot ID:"
        '
        'RichtxtboxLog
        '
        Me.RichtxtboxLog.Location = New System.Drawing.Point(131, 263)
        Me.RichtxtboxLog.Name = "RichtxtboxLog"
        Me.RichtxtboxLog.ReadOnly = True
        Me.RichtxtboxLog.Size = New System.Drawing.Size(332, 198)
        Me.RichtxtboxLog.TabIndex = 41
        Me.RichtxtboxLog.Text = ""
        '
        'lblaircraftused
        '
        Me.lblaircraftused.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblaircraftused.Location = New System.Drawing.Point(128, 167)
        Me.lblaircraftused.Name = "lblaircraftused"
        Me.lblaircraftused.Size = New System.Drawing.Size(267, 22)
        Me.lblaircraftused.TabIndex = 43
        '
        'lblaircraftusedtag
        '
        Me.lblaircraftusedtag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblaircraftusedtag.Location = New System.Drawing.Point(12, 167)
        Me.lblaircraftusedtag.Name = "lblaircraftusedtag"
        Me.lblaircraftusedtag.Size = New System.Drawing.Size(110, 22)
        Me.lblaircraftusedtag.TabIndex = 42
        Me.lblaircraftusedtag.Text = "Aircraft Used:"
        '
        'lbllandingrate
        '
        Me.lbllandingrate.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lbllandingrate.Location = New System.Drawing.Point(377, 74)
        Me.lbllandingrate.Name = "lbllandingrate"
        Me.lbllandingrate.Size = New System.Drawing.Size(78, 22)
        Me.lbllandingrate.TabIndex = 45
        '
        'lbllandingratetag
        '
        Me.lbllandingratetag.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lbllandingratetag.Location = New System.Drawing.Point(261, 74)
        Me.lbllandingratetag.Name = "lbllandingratetag"
        Me.lbllandingratetag.Size = New System.Drawing.Size(78, 22)
        Me.lbllandingratetag.TabIndex = 44
        Me.lbllandingratetag.Text = "Landing Rate:"
        '
        'frmResendReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 472)
        Me.Controls.Add(Me.lbllandingrate)
        Me.Controls.Add(Me.lbllandingratetag)
        Me.Controls.Add(Me.lblaircraftused)
        Me.Controls.Add(Me.lblaircraftusedtag)
        Me.Controls.Add(Me.RichtxtboxLog)
        Me.Controls.Add(Me.lblPilotID)
        Me.Controls.Add(Me.lblPilotIDTag)
        Me.Controls.Add(Me.lblFuelUsed)
        Me.Controls.Add(Me.lblFLightTime)
        Me.Controls.Add(Me.lblRoute)
        Me.Controls.Add(Me.lblAcRegistration)
        Me.Controls.Add(Me.lblArrival)
        Me.Controls.Add(Me.lblDeparture)
        Me.Controls.Add(Me.lblFlightNumber)
        Me.Controls.Add(Me.lblLogTag)
        Me.Controls.Add(Me.lblFuelUsedTag)
        Me.Controls.Add(Me.lblFlightTimeTag)
        Me.Controls.Add(Me.lblRouteTag)
        Me.Controls.Add(Me.lblAcRegistrationTag)
        Me.Controls.Add(Me.lblArrivalTag)
        Me.Controls.Add(Me.lblDepartureTag)
        Me.Controls.Add(Me.lblFlightNumberTag)
        Me.Controls.Add(Me.btnReadFile)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmResendReport"
        Me.Text = "Resend Log Files"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnReadFile As System.Windows.Forms.Button
    Friend WithEvents lblFlightNumberTag As System.Windows.Forms.Label
    Friend WithEvents lblDepartureTag As System.Windows.Forms.Label
    Friend WithEvents lblArrivalTag As System.Windows.Forms.Label
    Friend WithEvents lblAcRegistrationTag As System.Windows.Forms.Label
    Friend WithEvents lblRouteTag As System.Windows.Forms.Label
    Friend WithEvents lblFlightTimeTag As System.Windows.Forms.Label
    Friend WithEvents lblFuelUsedTag As System.Windows.Forms.Label
    Friend WithEvents lblLogTag As System.Windows.Forms.Label
    Friend WithEvents lblFlightNumber As System.Windows.Forms.Label
    Friend WithEvents lblDeparture As System.Windows.Forms.Label
    Friend WithEvents lblArrival As System.Windows.Forms.Label
    Friend WithEvents lblAcRegistration As System.Windows.Forms.Label
    Friend WithEvents lblRoute As System.Windows.Forms.Label
    Friend WithEvents lblFLightTime As System.Windows.Forms.Label
    Friend WithEvents lblFuelUsed As System.Windows.Forms.Label
    Friend WithEvents lblPilotID As System.Windows.Forms.Label
    Friend WithEvents lblPilotIDTag As System.Windows.Forms.Label
    Friend WithEvents RichtxtboxLog As System.Windows.Forms.RichTextBox
    Friend WithEvents lblaircraftused As System.Windows.Forms.Label
    Friend WithEvents lblaircraftusedtag As System.Windows.Forms.Label
    Friend WithEvents lbllandingrate As System.Windows.Forms.Label
    Friend WithEvents lbllandingratetag As System.Windows.Forms.Label
End Class
