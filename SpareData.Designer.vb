<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpareData
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpareData))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.spareDataGrid = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.cmdShowSpareData = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuImageButton1 = New Bunifu.UI.WinForms.BunifuImageButton()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        CType(Me.spareDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spareDataGrid
        '
        Me.spareDataGrid.AllowCustomTheming = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.spareDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.spareDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.spareDataGrid.BackgroundColor = System.Drawing.Color.Gray
        Me.spareDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.spareDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.spareDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.spareDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.spareDataGrid.ColumnHeadersHeight = 40
        Me.spareDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.spareDataGrid.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.spareDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.spareDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.spareDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.spareDataGrid.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.spareDataGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.spareDataGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.spareDataGrid.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.spareDataGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.spareDataGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.spareDataGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.spareDataGrid.CurrentTheme.Name = Nothing
        Me.spareDataGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.spareDataGrid.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.spareDataGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.spareDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.spareDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.spareDataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.spareDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.spareDataGrid.EnableHeadersVisualStyles = False
        Me.spareDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.spareDataGrid.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.spareDataGrid.HeaderBgColor = System.Drawing.Color.Empty
        Me.spareDataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.spareDataGrid.Location = New System.Drawing.Point(0, 81)
        Me.spareDataGrid.Name = "spareDataGrid"
        Me.spareDataGrid.RowHeadersVisible = False
        Me.spareDataGrid.RowTemplate.Height = 40
        Me.spareDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.spareDataGrid.Size = New System.Drawing.Size(878, 409)
        Me.spareDataGrid.TabIndex = 0
        Me.spareDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'cmdShowSpareData
        '
        Me.cmdShowSpareData.AllowAnimations = True
        Me.cmdShowSpareData.AllowMouseEffects = True
        Me.cmdShowSpareData.AllowToggling = False
        Me.cmdShowSpareData.AnimationSpeed = 200
        Me.cmdShowSpareData.AutoGenerateColors = False
        Me.cmdShowSpareData.AutoRoundBorders = True
        Me.cmdShowSpareData.AutoSizeLeftIcon = True
        Me.cmdShowSpareData.AutoSizeRightIcon = True
        Me.cmdShowSpareData.BackColor = System.Drawing.Color.Transparent
        Me.cmdShowSpareData.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.cmdShowSpareData.BackgroundImage = CType(resources.GetObject("cmdShowSpareData.BackgroundImage"), System.Drawing.Image)
        Me.cmdShowSpareData.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.cmdShowSpareData.ButtonText = "Show Spare Part Data"
        Me.cmdShowSpareData.ButtonTextMarginLeft = 0
        Me.cmdShowSpareData.ColorContrastOnClick = 45
        Me.cmdShowSpareData.ColorContrastOnHover = 45
        Me.cmdShowSpareData.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.cmdShowSpareData.CustomizableEdges = BorderEdges1
        Me.cmdShowSpareData.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdShowSpareData.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.cmdShowSpareData.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cmdShowSpareData.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.cmdShowSpareData.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.cmdShowSpareData.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdShowSpareData.ForeColor = System.Drawing.Color.White
        Me.cmdShowSpareData.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdShowSpareData.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.cmdShowSpareData.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.cmdShowSpareData.IconMarginLeft = 11
        Me.cmdShowSpareData.IconPadding = 10
        Me.cmdShowSpareData.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdShowSpareData.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.cmdShowSpareData.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.cmdShowSpareData.IconSize = 25
        Me.cmdShowSpareData.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.cmdShowSpareData.IdleBorderRadius = 32
        Me.cmdShowSpareData.IdleBorderThickness = 1
        Me.cmdShowSpareData.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.cmdShowSpareData.IdleIconLeftImage = Nothing
        Me.cmdShowSpareData.IdleIconRightImage = Nothing
        Me.cmdShowSpareData.IndicateFocus = False
        Me.cmdShowSpareData.Location = New System.Drawing.Point(705, 21)
        Me.cmdShowSpareData.Name = "cmdShowSpareData"
        Me.cmdShowSpareData.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.cmdShowSpareData.OnDisabledState.BorderRadius = 32
        Me.cmdShowSpareData.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.cmdShowSpareData.OnDisabledState.BorderThickness = 1
        Me.cmdShowSpareData.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cmdShowSpareData.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.cmdShowSpareData.OnDisabledState.IconLeftImage = Nothing
        Me.cmdShowSpareData.OnDisabledState.IconRightImage = Nothing
        Me.cmdShowSpareData.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdShowSpareData.onHoverState.BorderRadius = 32
        Me.cmdShowSpareData.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.cmdShowSpareData.onHoverState.BorderThickness = 1
        Me.cmdShowSpareData.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdShowSpareData.onHoverState.ForeColor = System.Drawing.Color.White
        Me.cmdShowSpareData.onHoverState.IconLeftImage = Nothing
        Me.cmdShowSpareData.onHoverState.IconRightImage = Nothing
        Me.cmdShowSpareData.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.cmdShowSpareData.OnIdleState.BorderRadius = 32
        Me.cmdShowSpareData.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.cmdShowSpareData.OnIdleState.BorderThickness = 1
        Me.cmdShowSpareData.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.cmdShowSpareData.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.cmdShowSpareData.OnIdleState.IconLeftImage = Nothing
        Me.cmdShowSpareData.OnIdleState.IconRightImage = Nothing
        Me.cmdShowSpareData.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.cmdShowSpareData.OnPressedState.BorderRadius = 32
        Me.cmdShowSpareData.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.cmdShowSpareData.OnPressedState.BorderThickness = 1
        Me.cmdShowSpareData.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.cmdShowSpareData.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.cmdShowSpareData.OnPressedState.IconLeftImage = Nothing
        Me.cmdShowSpareData.OnPressedState.IconRightImage = Nothing
        Me.cmdShowSpareData.Size = New System.Drawing.Size(160, 34)
        Me.cmdShowSpareData.TabIndex = 1
        Me.cmdShowSpareData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdShowSpareData.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.cmdShowSpareData.TextMarginLeft = 0
        Me.cmdShowSpareData.TextPadding = New System.Windows.Forms.Padding(0)
        Me.cmdShowSpareData.UseDefaultRadiusAndThickness = True
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
        Me.BunifuImageButton1.ImageSize = New System.Drawing.Size(59, 52)
        Me.BunifuImageButton1.ImageZoomSize = New System.Drawing.Size(60, 53)
        Me.BunifuImageButton1.InitialImage = CType(resources.GetObject("BunifuImageButton1.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton1.Location = New System.Drawing.Point(12, 13)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Rotation = 0
        Me.BunifuImageButton1.ShowActiveImage = True
        Me.BunifuImageButton1.ShowCursorChanges = True
        Me.BunifuImageButton1.ShowImageBorders = False
        Me.BunifuImageButton1.ShowSizeMarkers = False
        Me.BunifuImageButton1.Size = New System.Drawing.Size(60, 53)
        Me.BunifuImageButton1.TabIndex = 2
        Me.BunifuImageButton1.ToolTipText = ""
        Me.BunifuImageButton1.WaitOnLoad = False
        Me.BunifuImageButton1.Zoom = 0
        Me.BunifuImageButton1.ZoomSpeed = 10
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel1.Location = New System.Drawing.Point(286, 21)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(167, 26)
        Me.BunifuLabel1.TabIndex = 3
        Me.BunifuLabel1.Text = "Spare Part Data"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'SpareData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(878, 490)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.cmdShowSpareData)
        Me.Controls.Add(Me.spareDataGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SpareData"
        Me.Text = "SpareData"
        CType(Me.spareDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents spareDataGrid As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents cmdShowSpareData As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuImageButton1 As Bunifu.UI.WinForms.BunifuImageButton
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
End Class
