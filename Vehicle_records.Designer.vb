<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vehicle_records
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vehicle_records))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.RegesteredVehicleDataGrid = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.cmdShowVehicleData = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuImageButton1 = New Bunifu.UI.WinForms.BunifuImageButton()
        CType(Me.RegesteredVehicleDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel1.Location = New System.Drawing.Point(259, 25)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(269, 26)
        Me.BunifuLabel1.TabIndex = 0
        Me.BunifuLabel1.Text = "Vehicle Regestration Data"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'RegesteredVehicleDataGrid
        '
        Me.RegesteredVehicleDataGrid.AllowCustomTheming = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.RegesteredVehicleDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.RegesteredVehicleDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RegesteredVehicleDataGrid.BackgroundColor = System.Drawing.Color.Gray
        Me.RegesteredVehicleDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RegesteredVehicleDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.RegesteredVehicleDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RegesteredVehicleDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.RegesteredVehicleDataGrid.ColumnHeadersHeight = 40
        Me.RegesteredVehicleDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RegesteredVehicleDataGrid.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RegesteredVehicleDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.RegesteredVehicleDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RegesteredVehicleDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.RegesteredVehicleDataGrid.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.RegesteredVehicleDataGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RegesteredVehicleDataGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.RegesteredVehicleDataGrid.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.RegesteredVehicleDataGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.RegesteredVehicleDataGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.RegesteredVehicleDataGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.RegesteredVehicleDataGrid.CurrentTheme.Name = Nothing
        Me.RegesteredVehicleDataGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.RegesteredVehicleDataGrid.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RegesteredVehicleDataGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.RegesteredVehicleDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RegesteredVehicleDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RegesteredVehicleDataGrid.DefaultCellStyle = DataGridViewCellStyle6
        Me.RegesteredVehicleDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RegesteredVehicleDataGrid.EnableHeadersVisualStyles = False
        Me.RegesteredVehicleDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RegesteredVehicleDataGrid.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.RegesteredVehicleDataGrid.HeaderBgColor = System.Drawing.Color.Empty
        Me.RegesteredVehicleDataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.RegesteredVehicleDataGrid.Location = New System.Drawing.Point(0, 82)
        Me.RegesteredVehicleDataGrid.Name = "RegesteredVehicleDataGrid"
        Me.RegesteredVehicleDataGrid.RowHeadersVisible = False
        Me.RegesteredVehicleDataGrid.RowTemplate.Height = 40
        Me.RegesteredVehicleDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RegesteredVehicleDataGrid.Size = New System.Drawing.Size(878, 408)
        Me.RegesteredVehicleDataGrid.TabIndex = 3
        Me.RegesteredVehicleDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'cmdShowVehicleData
        '
        Me.cmdShowVehicleData.AllowAnimations = True
        Me.cmdShowVehicleData.AllowMouseEffects = True
        Me.cmdShowVehicleData.AllowToggling = False
        Me.cmdShowVehicleData.AnimationSpeed = 200
        Me.cmdShowVehicleData.AutoGenerateColors = False
        Me.cmdShowVehicleData.AutoRoundBorders = True
        Me.cmdShowVehicleData.AutoSizeLeftIcon = True
        Me.cmdShowVehicleData.AutoSizeRightIcon = True
        Me.cmdShowVehicleData.BackColor = System.Drawing.Color.Transparent
        Me.cmdShowVehicleData.BackColor1 = System.Drawing.Color.Transparent
        Me.cmdShowVehicleData.BackgroundImage = CType(resources.GetObject("cmdShowVehicleData.BackgroundImage"), System.Drawing.Image)
        Me.cmdShowVehicleData.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.cmdShowVehicleData.ButtonText = "Show Data"
        Me.cmdShowVehicleData.ButtonTextMarginLeft = 0
        Me.cmdShowVehicleData.ColorContrastOnClick = 45
        Me.cmdShowVehicleData.ColorContrastOnHover = 45
        Me.cmdShowVehicleData.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.cmdShowVehicleData.CustomizableEdges = BorderEdges2
        Me.cmdShowVehicleData.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdShowVehicleData.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.cmdShowVehicleData.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cmdShowVehicleData.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.cmdShowVehicleData.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.cmdShowVehicleData.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdShowVehicleData.ForeColor = System.Drawing.Color.White
        Me.cmdShowVehicleData.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdShowVehicleData.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.cmdShowVehicleData.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.cmdShowVehicleData.IconMarginLeft = 11
        Me.cmdShowVehicleData.IconPadding = 10
        Me.cmdShowVehicleData.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdShowVehicleData.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.cmdShowVehicleData.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.cmdShowVehicleData.IconSize = 25
        Me.cmdShowVehicleData.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.cmdShowVehicleData.IdleBorderRadius = 32
        Me.cmdShowVehicleData.IdleBorderThickness = 1
        Me.cmdShowVehicleData.IdleFillColor = System.Drawing.Color.Transparent
        Me.cmdShowVehicleData.IdleIconLeftImage = Nothing
        Me.cmdShowVehicleData.IdleIconRightImage = Nothing
        Me.cmdShowVehicleData.IndicateFocus = False
        Me.cmdShowVehicleData.Location = New System.Drawing.Point(715, 21)
        Me.cmdShowVehicleData.Name = "cmdShowVehicleData"
        Me.cmdShowVehicleData.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.cmdShowVehicleData.OnDisabledState.BorderRadius = 1
        Me.cmdShowVehicleData.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.cmdShowVehicleData.OnDisabledState.BorderThickness = 1
        Me.cmdShowVehicleData.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cmdShowVehicleData.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.cmdShowVehicleData.OnDisabledState.IconLeftImage = Nothing
        Me.cmdShowVehicleData.OnDisabledState.IconRightImage = Nothing
        Me.cmdShowVehicleData.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdShowVehicleData.onHoverState.BorderRadius = 1
        Me.cmdShowVehicleData.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.cmdShowVehicleData.onHoverState.BorderThickness = 1
        Me.cmdShowVehicleData.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdShowVehicleData.onHoverState.ForeColor = System.Drawing.Color.White
        Me.cmdShowVehicleData.onHoverState.IconLeftImage = Nothing
        Me.cmdShowVehicleData.onHoverState.IconRightImage = Nothing
        Me.cmdShowVehicleData.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.cmdShowVehicleData.OnIdleState.BorderRadius = 1
        Me.cmdShowVehicleData.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.cmdShowVehicleData.OnIdleState.BorderThickness = 1
        Me.cmdShowVehicleData.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.cmdShowVehicleData.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.cmdShowVehicleData.OnIdleState.IconLeftImage = Nothing
        Me.cmdShowVehicleData.OnIdleState.IconRightImage = Nothing
        Me.cmdShowVehicleData.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.cmdShowVehicleData.OnPressedState.BorderRadius = 1
        Me.cmdShowVehicleData.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.cmdShowVehicleData.OnPressedState.BorderThickness = 1
        Me.cmdShowVehicleData.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.cmdShowVehicleData.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.cmdShowVehicleData.OnPressedState.IconLeftImage = Nothing
        Me.cmdShowVehicleData.OnPressedState.IconRightImage = Nothing
        Me.cmdShowVehicleData.Size = New System.Drawing.Size(150, 34)
        Me.cmdShowVehicleData.TabIndex = 4
        Me.cmdShowVehicleData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdShowVehicleData.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.cmdShowVehicleData.TextMarginLeft = 0
        Me.cmdShowVehicleData.TextPadding = New System.Windows.Forms.Padding(0)
        Me.cmdShowVehicleData.UseDefaultRadiusAndThickness = True
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.ActiveImage = Nothing
        Me.BunifuImageButton1.AllowAnimations = True
        Me.BunifuImageButton1.AllowBuffering = False
        Me.BunifuImageButton1.AllowToggling = False
        Me.BunifuImageButton1.AllowZooming = True
        Me.BunifuImageButton1.AllowZoomingOnFocus = False
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.White
        Me.BunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuImageButton1.ErrorImage = CType(resources.GetObject("BunifuImageButton1.ErrorImage"), System.Drawing.Image)
        Me.BunifuImageButton1.FadeWhenInactive = False
        Me.BunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.ImageLocation = Nothing
        Me.BunifuImageButton1.ImageMargin = 0
        Me.BunifuImageButton1.ImageSize = New System.Drawing.Size(59, 49)
        Me.BunifuImageButton1.ImageZoomSize = New System.Drawing.Size(60, 50)
        Me.BunifuImageButton1.InitialImage = CType(resources.GetObject("BunifuImageButton1.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton1.Location = New System.Drawing.Point(12, 13)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Rotation = 0
        Me.BunifuImageButton1.ShowActiveImage = True
        Me.BunifuImageButton1.ShowCursorChanges = True
        Me.BunifuImageButton1.ShowImageBorders = False
        Me.BunifuImageButton1.ShowSizeMarkers = False
        Me.BunifuImageButton1.Size = New System.Drawing.Size(60, 50)
        Me.BunifuImageButton1.TabIndex = 5
        Me.BunifuImageButton1.ToolTipText = ""
        Me.BunifuImageButton1.WaitOnLoad = False
        Me.BunifuImageButton1.Zoom = 0
        Me.BunifuImageButton1.ZoomSpeed = 10
        '
        'Vehicle_records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(878, 490)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.cmdShowVehicleData)
        Me.Controls.Add(Me.RegesteredVehicleDataGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Vehicle_records"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.RegesteredVehicleDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents RegesteredVehicleDataGrid As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents cmdShowVehicleData As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuImageButton1 As Bunifu.UI.WinForms.BunifuImageButton
End Class
