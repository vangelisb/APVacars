<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlightInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFlightInformation))
        Me.lblFlightNumber = New System.Windows.Forms.Label()
        Me.lblFlightNumberTag = New System.Windows.Forms.Label()
        Me.lblArrival = New System.Windows.Forms.Label()
        Me.lblArrivalTag = New System.Windows.Forms.Label()
        Me.lblDeparture = New System.Windows.Forms.Label()
        Me.lblDepartureTag = New System.Windows.Forms.Label()
        Me.lblAircraftTag = New System.Windows.Forms.Label()
        Me.lblAircraft = New System.Windows.Forms.Label()
        Me.lblDepartureTimeTag = New System.Windows.Forms.Label()
        Me.lblArrivalTimeTag = New System.Windows.Forms.Label()
        Me.lblArrivalTime = New System.Windows.Forms.Label()
        Me.lblFlightLevelTag = New System.Windows.Forms.Label()
        Me.lblFlightLevel = New System.Windows.Forms.Label()
        Me.lblRouteTag = New System.Windows.Forms.Label()
        Me.lblRoute = New System.Windows.Forms.Label()
        Me.lblDepartureTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFlightNumber
        '
        Me.lblFlightNumber.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlightNumber.Location = New System.Drawing.Point(122, 9)
        Me.lblFlightNumber.Name = "lblFlightNumber"
        Me.lblFlightNumber.Size = New System.Drawing.Size(56, 16)
        Me.lblFlightNumber.TabIndex = 29
        '
        'lblFlightNumberTag
        '
        Me.lblFlightNumberTag.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlightNumberTag.Location = New System.Drawing.Point(12, 9)
        Me.lblFlightNumberTag.Name = "lblFlightNumberTag"
        Me.lblFlightNumberTag.Size = New System.Drawing.Size(78, 22)
        Me.lblFlightNumberTag.TabIndex = 28
        Me.lblFlightNumberTag.Text = "Flight Number:"
        '
        'lblArrival
        '
        Me.lblArrival.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrival.Location = New System.Drawing.Point(122, 53)
        Me.lblArrival.Name = "lblArrival"
        Me.lblArrival.Size = New System.Drawing.Size(48, 16)
        Me.lblArrival.TabIndex = 27
        '
        'lblArrivalTag
        '
        Me.lblArrivalTag.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrivalTag.Location = New System.Drawing.Point(12, 53)
        Me.lblArrivalTag.Name = "lblArrivalTag"
        Me.lblArrivalTag.Size = New System.Drawing.Size(85, 22)
        Me.lblArrivalTag.TabIndex = 26
        Me.lblArrivalTag.Text = "Arrival Aiport:"
        '
        'lblDeparture
        '
        Me.lblDeparture.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeparture.Location = New System.Drawing.Point(122, 31)
        Me.lblDeparture.Name = "lblDeparture"
        Me.lblDeparture.Size = New System.Drawing.Size(48, 16)
        Me.lblDeparture.TabIndex = 25
        '
        'lblDepartureTag
        '
        Me.lblDepartureTag.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartureTag.Location = New System.Drawing.Point(12, 31)
        Me.lblDepartureTag.Name = "lblDepartureTag"
        Me.lblDepartureTag.Size = New System.Drawing.Size(103, 22)
        Me.lblDepartureTag.TabIndex = 24
        Me.lblDepartureTag.Text = "Departure Aiport:"
        '
        'lblAircraftTag
        '
        Me.lblAircraftTag.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAircraftTag.Location = New System.Drawing.Point(12, 119)
        Me.lblAircraftTag.Name = "lblAircraftTag"
        Me.lblAircraftTag.Size = New System.Drawing.Size(52, 22)
        Me.lblAircraftTag.TabIndex = 30
        Me.lblAircraftTag.Text = "Aircraft:"
        '
        'lblAircraft
        '
        Me.lblAircraft.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAircraft.Location = New System.Drawing.Point(90, 119)
        Me.lblAircraft.Name = "lblAircraft"
        Me.lblAircraft.Size = New System.Drawing.Size(273, 22)
        Me.lblAircraft.TabIndex = 31
        '
        'lblDepartureTimeTag
        '
        Me.lblDepartureTimeTag.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartureTimeTag.Location = New System.Drawing.Point(12, 75)
        Me.lblDepartureTimeTag.Name = "lblDepartureTimeTag"
        Me.lblDepartureTimeTag.Size = New System.Drawing.Size(153, 22)
        Me.lblDepartureTimeTag.TabIndex = 32
        Me.lblDepartureTimeTag.Text = "Schedule Time Of Departure:"
        '
        'lblArrivalTimeTag
        '
        Me.lblArrivalTimeTag.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrivalTimeTag.Location = New System.Drawing.Point(12, 97)
        Me.lblArrivalTimeTag.Name = "lblArrivalTimeTag"
        Me.lblArrivalTimeTag.Size = New System.Drawing.Size(153, 22)
        Me.lblArrivalTimeTag.TabIndex = 34
        Me.lblArrivalTimeTag.Text = "Schedule Time Of Arrival:"
        '
        'lblArrivalTime
        '
        Me.lblArrivalTime.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrivalTime.Location = New System.Drawing.Point(171, 97)
        Me.lblArrivalTime.Name = "lblArrivalTime"
        Me.lblArrivalTime.Size = New System.Drawing.Size(86, 16)
        Me.lblArrivalTime.TabIndex = 35
        '
        'lblFlightLevelTag
        '
        Me.lblFlightLevelTag.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlightLevelTag.Location = New System.Drawing.Point(12, 141)
        Me.lblFlightLevelTag.Name = "lblFlightLevelTag"
        Me.lblFlightLevelTag.Size = New System.Drawing.Size(78, 22)
        Me.lblFlightLevelTag.TabIndex = 36
        Me.lblFlightLevelTag.Text = "Flight Level:"
        '
        'lblFlightLevel
        '
        Me.lblFlightLevel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlightLevel.Location = New System.Drawing.Point(90, 141)
        Me.lblFlightLevel.Name = "lblFlightLevel"
        Me.lblFlightLevel.Size = New System.Drawing.Size(157, 16)
        Me.lblFlightLevel.TabIndex = 37
        '
        'lblRouteTag
        '
        Me.lblRouteTag.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRouteTag.Location = New System.Drawing.Point(12, 163)
        Me.lblRouteTag.Name = "lblRouteTag"
        Me.lblRouteTag.Size = New System.Drawing.Size(42, 22)
        Me.lblRouteTag.TabIndex = 38
        Me.lblRouteTag.Text = "Route:"
        '
        'lblRoute
        '
        Me.lblRoute.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoute.Location = New System.Drawing.Point(50, 163)
        Me.lblRoute.Name = "lblRoute"
        Me.lblRoute.Size = New System.Drawing.Size(408, 22)
        Me.lblRoute.TabIndex = 39
        '
        'lblDepartureTime
        '
        Me.lblDepartureTime.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartureTime.Location = New System.Drawing.Point(171, 75)
        Me.lblDepartureTime.Name = "lblDepartureTime"
        Me.lblDepartureTime.Size = New System.Drawing.Size(86, 16)
        Me.lblDepartureTime.TabIndex = 40
        '
        'frmFlightInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 273)
        Me.Controls.Add(Me.lblDepartureTime)
        Me.Controls.Add(Me.lblRoute)
        Me.Controls.Add(Me.lblRouteTag)
        Me.Controls.Add(Me.lblFlightLevel)
        Me.Controls.Add(Me.lblFlightLevelTag)
        Me.Controls.Add(Me.lblArrivalTime)
        Me.Controls.Add(Me.lblArrivalTimeTag)
        Me.Controls.Add(Me.lblDepartureTimeTag)
        Me.Controls.Add(Me.lblAircraft)
        Me.Controls.Add(Me.lblAircraftTag)
        Me.Controls.Add(Me.lblFlightNumber)
        Me.Controls.Add(Me.lblFlightNumberTag)
        Me.Controls.Add(Me.lblArrival)
        Me.Controls.Add(Me.lblArrivalTag)
        Me.Controls.Add(Me.lblDeparture)
        Me.Controls.Add(Me.lblDepartureTag)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFlightInformation"
        Me.Text = "Flight Information"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFlightNumber As System.Windows.Forms.Label
    Friend WithEvents lblFlightNumberTag As System.Windows.Forms.Label
    Friend WithEvents lblArrival As System.Windows.Forms.Label
    Friend WithEvents lblArrivalTag As System.Windows.Forms.Label
    Friend WithEvents lblDeparture As System.Windows.Forms.Label
    Friend WithEvents lblDepartureTag As System.Windows.Forms.Label
    Friend WithEvents lblAircraftTag As System.Windows.Forms.Label
    Friend WithEvents lblAircraft As System.Windows.Forms.Label
    Friend WithEvents lblDepartureTimeTag As System.Windows.Forms.Label
    Friend WithEvents lblArrivalTimeTag As System.Windows.Forms.Label
    Friend WithEvents lblArrivalTime As System.Windows.Forms.Label
    Friend WithEvents lblFlightLevelTag As System.Windows.Forms.Label
    Friend WithEvents lblFlightLevel As System.Windows.Forms.Label
    Friend WithEvents lblRouteTag As System.Windows.Forms.Label
    Friend WithEvents lblRoute As System.Windows.Forms.Label
    Friend WithEvents lblDepartureTime As System.Windows.Forms.Label
End Class
