﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelCurrentRegion = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripMain = New System.Windows.Forms.MenuStrip()
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RussianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageEC2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataListViewEC2 = New BrightIdeasSoftware.DataListView()
        Me.MenuStripInstanceFilter = New System.Windows.Forms.MenuStrip()
        Me.RefreshInstanceListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFilterPresentation = New System.Windows.Forms.MenuStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TreeViewInstanceProperties = New System.Windows.Forms.TreeView()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStripMain.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPageEC2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataListViewEC2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripInstanceFilter.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelCurrentRegion})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 624)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1415, 22)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelCurrentRegion
        '
        Me.ToolStripStatusLabelCurrentRegion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.ToolStripStatusLabelCurrentRegion.Name = "ToolStripStatusLabelCurrentRegion"
        Me.ToolStripStatusLabelCurrentRegion.Size = New System.Drawing.Size(76, 20)
        Me.ToolStripStatusLabelCurrentRegion.Text = "< region >"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem1.Tag = "us-east-1"
        Me.ToolStripMenuItem1.Text = "us-east-1 (N. Virginia)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem2.Tag = "us-east-2"
        Me.ToolStripMenuItem2.Text = "us-east-2 (Ohio)"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem3.Tag = "us-west-1"
        Me.ToolStripMenuItem3.Text = "us-west-1 (N. California)"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem4.Tag = "us-west-2"
        Me.ToolStripMenuItem4.Text = "us-west-2 (Oregon)"
        '
        'MenuStripMain
        '
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountsToolStripMenuItem, Me.LanguageToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Size = New System.Drawing.Size(1415, 24)
        Me.MenuStripMain.TabIndex = 1
        Me.MenuStripMain.Text = "MenuStrip1"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.AccountsToolStripMenuItem.Text = "Add New Account"
        '
        'LanguageToolStripMenuItem
        '
        Me.LanguageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnglishToolStripMenuItem, Me.RussianToolStripMenuItem})
        Me.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem"
        Me.LanguageToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.LanguageToolStripMenuItem.Text = "Language"
        '
        'EnglishToolStripMenuItem
        '
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        Me.EnglishToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.EnglishToolStripMenuItem.Text = "English"
        '
        'RussianToolStripMenuItem
        '
        Me.RussianToolStripMenuItem.Name = "RussianToolStripMenuItem"
        Me.RussianToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.RussianToolStripMenuItem.Text = "Russian"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPageEC2)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 24)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1415, 600)
        Me.TabControl.TabIndex = 4
        '
        'TabPageEC2
        '
        Me.TabPageEC2.Controls.Add(Me.Panel2)
        Me.TabPageEC2.Controls.Add(Me.Panel1)
        Me.TabPageEC2.Location = New System.Drawing.Point(4, 24)
        Me.TabPageEC2.Name = "TabPageEC2"
        Me.TabPageEC2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEC2.Size = New System.Drawing.Size(1407, 572)
        Me.TabPageEC2.TabIndex = 0
        Me.TabPageEC2.Text = "Instances"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.DataListViewEC2)
        Me.Panel2.Controls.Add(Me.MenuStripInstanceFilter)
        Me.Panel2.Controls.Add(Me.MenuStripFilterPresentation)
        Me.Panel2.Location = New System.Drawing.Point(2, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1085, 544)
        Me.Panel2.TabIndex = 12
        '
        'DataListViewEC2
        '
        Me.DataListViewEC2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataListViewEC2.CellEditUseWholeCell = False
        Me.DataListViewEC2.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataListViewEC2.DataSource = Nothing
        Me.DataListViewEC2.FullRowSelect = True
        Me.DataListViewEC2.HideSelection = False
        Me.DataListViewEC2.IsSearchOnSortColumn = False
        Me.DataListViewEC2.Location = New System.Drawing.Point(6, 27)
        Me.DataListViewEC2.Name = "DataListViewEC2"
        Me.DataListViewEC2.ShowGroups = False
        Me.DataListViewEC2.Size = New System.Drawing.Size(1079, 492)
        Me.DataListViewEC2.TabIndex = 9
        Me.DataListViewEC2.UseFiltering = True
        Me.DataListViewEC2.View = System.Windows.Forms.View.Details
        '
        'MenuStripInstanceFilter
        '
        Me.MenuStripInstanceFilter.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStripInstanceFilter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshInstanceListToolStripMenuItem, Me.FilterByToolStripMenuItem})
        Me.MenuStripInstanceFilter.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripInstanceFilter.Name = "MenuStripInstanceFilter"
        Me.MenuStripInstanceFilter.Size = New System.Drawing.Size(127, 24)
        Me.MenuStripInstanceFilter.TabIndex = 10
        Me.MenuStripInstanceFilter.Text = "MenuStrip2"
        '
        'RefreshInstanceListToolStripMenuItem
        '
        Me.RefreshInstanceListToolStripMenuItem.Name = "RefreshInstanceListToolStripMenuItem"
        Me.RefreshInstanceListToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.RefreshInstanceListToolStripMenuItem.Text = "Refresh"
        '
        'FilterByToolStripMenuItem
        '
        Me.FilterByToolStripMenuItem.Name = "FilterByToolStripMenuItem"
        Me.FilterByToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FilterByToolStripMenuItem.Text = "Filter by"
        '
        'MenuStripFilterPresentation
        '
        Me.MenuStripFilterPresentation.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.MenuStripFilterPresentation.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStripFilterPresentation.Location = New System.Drawing.Point(195, 0)
        Me.MenuStripFilterPresentation.Name = "MenuStripFilterPresentation"
        Me.MenuStripFilterPresentation.Size = New System.Drawing.Size(202, 24)
        Me.MenuStripFilterPresentation.TabIndex = 11
        Me.MenuStripFilterPresentation.Text = "MenuStrip2"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TreeViewInstanceProperties)
        Me.Panel1.Location = New System.Drawing.Point(1093, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(310, 541)
        Me.Panel1.TabIndex = 8
        '
        'TreeViewInstanceProperties
        '
        Me.TreeViewInstanceProperties.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeViewInstanceProperties.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TreeViewInstanceProperties.Location = New System.Drawing.Point(0, 0)
        Me.TreeViewInstanceProperties.Name = "TreeViewInstanceProperties"
        Me.TreeViewInstanceProperties.Size = New System.Drawing.Size(310, 519)
        Me.TreeViewInstanceProperties.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1415, 646)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStripMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStripMain
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AWS EC2 Console"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPageEC2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataListViewEC2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripInstanceFilter.ResumeLayout(False)
        Me.MenuStripInstanceFilter.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents MenuStripMain As MenuStrip
    Friend WithEvents AccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPageEC2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TreeViewInstanceProperties As TreeView
    Friend WithEvents DataListViewEC2 As BrightIdeasSoftware.DataListView
    Friend WithEvents MenuStripInstanceFilter As MenuStrip
    Friend WithEvents FilterByToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStripFilterPresentation As MenuStrip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LanguageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnglishToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RussianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabelCurrentRegion As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents RefreshInstanceListToolStripMenuItem As ToolStripMenuItem
End Class
