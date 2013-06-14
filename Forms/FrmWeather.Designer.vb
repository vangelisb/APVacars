<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWeather
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWeather))
        Me.lbldepartureairportwtag = New System.Windows.Forms.Label()
        Me.lbldepartureairportw = New System.Windows.Forms.Label()
        Me.lblarrivalairportwtag = New System.Windows.Forms.Label()
        Me.lblarrivalairportw = New System.Windows.Forms.Label()
        Me.lblairporticaowtag = New System.Windows.Forms.Label()
        Me.txtairporticaoinputwtag = New System.Windows.Forms.TextBox()
        Me.lblairporticaow = New System.Windows.Forms.Label()
        Me.btngetweather = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbldepartureairportwtag
        '
        Me.lbldepartureairportwtag.AutoSize = True
        Me.lbldepartureairportwtag.Location = New System.Drawing.Point(12, 9)
        Me.lbldepartureairportwtag.Name = "lbldepartureairportwtag"
        Me.lbldepartureairportwtag.Size = New System.Drawing.Size(93, 13)
        Me.lbldepartureairportwtag.TabIndex = 0
        Me.lbldepartureairportwtag.Text = "Departure Airport :"
        '
        'lbldepartureairportw
        '
        Me.lbldepartureairportw.AutoSize = True
        Me.lbldepartureairportw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbldepartureairportw.Location = New System.Drawing.Point(12, 38)
        Me.lbldepartureairportw.Name = "lbldepartureairportw"
        Me.lbldepartureairportw.Size = New System.Drawing.Size(0, 13)
        Me.lbldepartureairportw.TabIndex = 1
        '
        'lblarrivalairportwtag
        '
        Me.lblarrivalairportwtag.AutoSize = True
        Me.lblarrivalairportwtag.Location = New System.Drawing.Point(12, 64)
        Me.lblarrivalairportwtag.Name = "lblarrivalairportwtag"
        Me.lblarrivalairportwtag.Size = New System.Drawing.Size(78, 13)
        Me.lblarrivalairportwtag.TabIndex = 2
        Me.lblarrivalairportwtag.Text = "Arrival Airport : "
        '
        'lblarrivalairportw
        '
        Me.lblarrivalairportw.AutoSize = True
        Me.lblarrivalairportw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblarrivalairportw.Location = New System.Drawing.Point(12, 96)
        Me.lblarrivalairportw.Name = "lblarrivalairportw"
        Me.lblarrivalairportw.Size = New System.Drawing.Size(0, 13)
        Me.lblarrivalairportw.TabIndex = 3
        '
        'lblairporticaowtag
        '
        Me.lblairporticaowtag.AutoSize = True
        Me.lblairporticaowtag.Location = New System.Drawing.Point(12, 137)
        Me.lblairporticaowtag.Name = "lblairporticaowtag"
        Me.lblairporticaowtag.Size = New System.Drawing.Size(94, 13)
        Me.lblairporticaowtag.TabIndex = 4
        Me.lblairporticaowtag.Text = "Insert Airport ICAO"
        '
        'txtairporticaoinputwtag
        '
        Me.txtairporticaoinputwtag.Location = New System.Drawing.Point(153, 137)
        Me.txtairporticaoinputwtag.Name = "txtairporticaoinputwtag"
        Me.txtairporticaoinputwtag.Size = New System.Drawing.Size(100, 20)
        Me.txtairporticaoinputwtag.TabIndex = 5
        '
        'lblairporticaow
        '
        Me.lblairporticaow.AutoSize = True
        Me.lblairporticaow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblairporticaow.Location = New System.Drawing.Point(12, 167)
        Me.lblairporticaow.Name = "lblairporticaow"
        Me.lblairporticaow.Size = New System.Drawing.Size(0, 13)
        Me.lblairporticaow.TabIndex = 6
        '
        'btngetweather
        '
        Me.btngetweather.Location = New System.Drawing.Point(451, 215)
        Me.btngetweather.Name = "btngetweather"
        Me.btngetweather.Size = New System.Drawing.Size(99, 23)
        Me.btngetweather.TabIndex = 7
        Me.btngetweather.Text = "Get Weather"
        Me.btngetweather.UseVisualStyleBackColor = True
        '
        'FrmWeather
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 250)
        Me.Controls.Add(Me.btngetweather)
        Me.Controls.Add(Me.lblairporticaow)
        Me.Controls.Add(Me.txtairporticaoinputwtag)
        Me.Controls.Add(Me.lblairporticaowtag)
        Me.Controls.Add(Me.lblarrivalairportw)
        Me.Controls.Add(Me.lblarrivalairportwtag)
        Me.Controls.Add(Me.lbldepartureairportw)
        Me.Controls.Add(Me.lbldepartureairportwtag)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWeather"
        Me.Text = "Weather Briefing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldepartureairportwtag As System.Windows.Forms.Label
    Friend WithEvents lbldepartureairportw As System.Windows.Forms.Label
    Friend WithEvents lblarrivalairportwtag As System.Windows.Forms.Label
    Friend WithEvents lblarrivalairportw As System.Windows.Forms.Label
    Friend WithEvents lblairporticaowtag As System.Windows.Forms.Label
    Friend WithEvents txtairporticaoinputwtag As System.Windows.Forms.TextBox
    Friend WithEvents lblairporticaow As System.Windows.Forms.Label
    Friend WithEvents btngetweather As System.Windows.Forms.Button
End Class
