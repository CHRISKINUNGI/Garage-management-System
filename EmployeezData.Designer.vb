<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeezData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeezData))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.employeeDataGrid = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.btnShowEmpData = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.cmdEmployeeBack = New Bunifu.UI.WinForms.BunifuImageButton()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        CType(Me.employeeDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'employeeDataGrid
        '
        Me.employeeDataGrid.AllowCustomTheming = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.employeeDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.employeeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.employeeDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.employeeDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.employeeDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.employeeDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.employeeDataGrid.ColumnHeadersHeight = 40
        Me.employeeDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.employeeDataGrid.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.employeeDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.employeeDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.employeeDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.employeeDataGrid.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.employeeDataGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.employeeDataGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.employeeDataGrid.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.employeeDataGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.employeeDataGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.employeeDataGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.employeeDataGrid.CurrentTheme.Name = Nothing
        Me.employeeDataGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.employeeDataGrid.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.employeeDataGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.employeeDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.employeeDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.employeeDataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.employeeDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.employeeDataGrid.EnableHeadersVisualStyles = False
        Me.employeeDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.employeeDataGrid.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.employeeDataGrid.HeaderBgColor = System.Drawing.Color.Empty
        Me.employeeDataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.employeeDataGrid.Location = New System.Drawing.Point(0, 82)
        Me.employeeDataGrid.Name = "employeeDataGrid"
        Me.employeeDataGrid.RowHeadersVisible = False
        Me.employeeDataGrid.RowTemplate.Height = 40
        Me.employeeDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.employeeDataGrid.Size = New System.Drawing.Size(878, 408)
        Me.employeeDataGrid.TabIndex = 2
        Me.employeeDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'btnShowEmpData
        '
        Me.btnShowEmpData.AllowAnimations = True
        Me.btnShowEmpData.AllowMouseEffects = True
        Me.btnShowEmpData.AllowToggling = False
        Me.btnShowEmpData.AnimationSpeed = 200
        Me.btnShowEmpData.AutoGenerateColors = False
        Me.btnShowEmpData.AutoRoundBorders = True
        Me.btnShowEmpData.AutoSizeLeftIcon = True
        Me.btnShowEmpData.AutoSizeRightIcon = True
        Me.btnShowEmpData.BackColor = System.Drawing.Color.Transparent
        Me.btnShowEmpData.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.btnShowEmpData.BackgroundImage = CType(resources.GetObject("btnShowEmpData.BackgroundImage"), System.Drawing.Image)
        Me.btnShowEmpData.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnShowEmpData.ButtonText = "Show Employee Data"
        Me.btnShowEmpData.ButtonTextMarginLeft = 0
        Me.btnShowEmpData.ColorContrastOnClick = 45
        Me.btnShowEmpData.ColorContrastOnHover = 45
        Me.btnShowEmpData.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btnShowEmpData.CustomizableEdges = BorderEdges1
        Me.btnShowEmpData.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnShowEmpData.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnShowEmpData.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnShowEmpData.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnShowEmpData.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnShowEmpData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowEmpData.ForeColor = System.Drawing.Color.White
        Me.btnShowEmpData.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowEmpData.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnShowEmpData.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btnShowEmpData.IconMarginLeft = 11
        Me.btnShowEmpData.IconPadding = 10
        Me.btnShowEmpData.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowEmpData.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnShowEmpData.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btnShowEmpData.IconSize = 25
        Me.btnShowEmpData.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.btnShowEmpData.IdleBorderRadius = 32
        Me.btnShowEmpData.IdleBorderThickness = 1
        Me.btnShowEmpData.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnShowEmpData.IdleIconLeftImage = Nothing
        Me.btnShowEmpData.IdleIconRightImage = Nothing
        Me.btnShowEmpData.IndicateFocus = False
        Me.btnShowEmpData.Location = New System.Drawing.Point(715, 21)
        Me.btnShowEmpData.Name = "btnShowEmpData"
        Me.btnShowEmpData.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnShowEmpData.OnDisabledState.BorderRadius = 1
        Me.btnShowEmpData.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnShowEmpData.OnDisabledState.BorderThickness = 1
        Me.btnShowEmpData.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnShowEmpData.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnShowEmpData.OnDisabledState.IconLeftImage = Nothing
        Me.btnShowEmpData.OnDisabledState.IconRightImage = Nothing
        Me.btnShowEmpData.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShowEmpData.onHoverState.BorderRadius = 1
        Me.btnShowEmpData.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnShowEmpData.onHoverState.BorderThickness = 1
        Me.btnShowEmpData.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShowEmpData.onHoverState.ForeColor = System.Drawing.Color.White
        Me.btnShowEmpData.onHoverState.IconLeftImage = Nothing
        Me.btnShowEmpData.onHoverState.IconRightImage = Nothing
        Me.btnShowEmpData.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnShowEmpData.OnIdleState.BorderRadius = 1
        Me.btnShowEmpData.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnShowEmpData.OnIdleState.BorderThickness = 1
        Me.btnShowEmpData.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnShowEmpData.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.btnShowEmpData.OnIdleState.IconLeftImage = Nothing
        Me.btnShowEmpData.OnIdleState.IconRightImage = Nothing
        Me.btnShowEmpData.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnShowEmpData.OnPressedState.BorderRadius = 1
        Me.btnShowEmpData.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnShowEmpData.OnPressedState.BorderThickness = 1
        Me.btnShowEmpData.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnShowEmpData.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btnShowEmpData.OnPressedState.IconLeftImage = Nothing
        Me.btnShowEmpData.OnPressedState.IconRightImage = Nothing
        Me.btnShowEmpData.Size = New System.Drawing.Size(150, 34)
        Me.btnShowEmpData.TabIndex = 1
        Me.btnShowEmpData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnShowEmpData.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnShowEmpData.TextMarginLeft = 0
        Me.btnShowEmpData.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnShowEmpData.UseDefaultRadiusAndThickness = True
        '
        'cmdEmployeeBack
        '
        Me.cmdEmployeeBack.ActiveImage = Nothing
        Me.cmdEmployeeBack.AllowAnimations = True
        Me.cmdEmployeeBack.AllowBuffering = False
        Me.cmdEmployeeBack.AllowToggling = False
        Me.cmdEmployeeBack.AllowZooming = True
        Me.cmdEmployeeBack.AllowZoomingOnFocus = False
        Me.cmdEmployeeBack.BackColor = System.Drawing.Color.White
        Me.cmdEmployeeBack.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdEmployeeBack.ErrorImage = CType(resources.GetObject("cmdEmployeeBack.ErrorImage"), System.Drawing.Image)
        Me.cmdEmployeeBack.FadeWhenInactive = False
        Me.cmdEmployeeBack.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal
        Me.cmdEmployeeBack.Image = CType(resources.GetObject("cmdEmployeeBack.Image"), System.Drawing.Image)
        Me.cmdEmployeeBack.ImageActive = Nothing
        Me.cmdEmployeeBack.ImageLocation = Nothing
        Me.cmdEmployeeBack.ImageMargin = 0
        Me.cmdEmployeeBack.ImageSize = New System.Drawing.Size(59, 49)
        Me.cmdEmployeeBack.ImageZoomSize = New System.Drawing.Size(60, 50)
        Me.cmdEmployeeBack.InitialImage = CType(resources.GetObject("cmdEmployeeBack.InitialImage"), System.Drawing.Image)
        Me.cmdEmployeeBack.Location = New System.Drawing.Point(12, 13)
        Me.cmdEmployeeBack.Name = "cmdEmployeeBack"
        Me.cmdEmployeeBack.Rotation = 0
        Me.cmdEmployeeBack.ShowActiveImage = True
        Me.cmdEmployeeBack.ShowCursorChanges = True
        Me.cmdEmployeeBack.ShowImageBorders = False
        Me.cmdEmployeeBack.ShowSizeMarkers = False
        Me.cmdEmployeeBack.Size = New System.Drawing.Size(60, 50)
        Me.cmdEmployeeBack.TabIndex = 3
        Me.cmdEmployeeBack.ToolTipText = ""
        Me.cmdEmployeeBack.WaitOnLoad = False
        Me.cmdEmployeeBack.Zoom = 0
        Me.cmdEmployeeBack.ZoomSpeed = 10
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuLabel1.Location = New System.Drawing.Point(259, 25)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(156, 26)
        Me.BunifuLabel1.TabIndex = 4
        Me.BunifuLabel1.Text = "Employee Data"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'EmployeezData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(878, 490)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.cmdEmployeeBack)
        Me.Controls.Add(Me.employeeDataGrid)
        Me.Controls.Add(Me.btnShowEmpData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EmployeezData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmployeezData"
        CType(Me.employeeDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShowEmpData As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents employeeDataGrid As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents cmdEmployeeBack As Bunifu.UI.WinForms.BunifuImageButton
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
End Class
