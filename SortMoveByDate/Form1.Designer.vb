﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbBrowseSource = New System.Windows.Forms.ToolStripButton()
        Me.tbSource = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbPopulate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbDestination = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbBrowseDestination = New System.Windows.Forms.ToolStripButton()
        Me.tsbMove = New System.Windows.Forms.ToolStripButton()
        Me.ssMain = New System.Windows.Forms.StatusStrip()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lvLeft = New System.Windows.Forms.ListView()
        Me.ssLeft = New System.Windows.Forms.StatusStrip()
        Me.lvRight = New System.Windows.Forms.ListView()
        Me.ssRight = New System.Windows.Forms.StatusStrip()
        Me.tsStatusLeftText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tbStatusRightText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tbCutoff = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbPlusMinus = New System.Windows.Forms.ToolStripButton()
        Me.tsMain.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ssLeft.SuspendLayout()
        Me.ssRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBrowseSource, Me.tbSource, Me.tsbPopulate, Me.ToolStripSeparator1, Me.tbDestination, Me.tsbBrowseDestination, Me.tsbMove, Me.tbCutoff, Me.tsbPlusMinus})
        Me.tsMain.Location = New System.Drawing.Point(0, 0)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1024, 27)
        Me.tsMain.TabIndex = 0
        Me.tsMain.Text = "ToolStrip1"
        '
        'tsbBrowseSource
        '
        Me.tsbBrowseSource.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbBrowseSource.Image = CType(resources.GetObject("tsbBrowseSource.Image"), System.Drawing.Image)
        Me.tsbBrowseSource.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBrowseSource.Name = "tsbBrowseSource"
        Me.tsbBrowseSource.Size = New System.Drawing.Size(58, 24)
        Me.tsbBrowseSource.Text = "Source"
        '
        'tbSource
        '
        Me.tbSource.Name = "tbSource"
        Me.tbSource.Size = New System.Drawing.Size(250, 27)
        '
        'tsbPopulate
        '
        Me.tsbPopulate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbPopulate.Image = CType(resources.GetObject("tsbPopulate.Image"), System.Drawing.Image)
        Me.tsbPopulate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPopulate.Name = "tsbPopulate"
        Me.tsbPopulate.Size = New System.Drawing.Size(71, 24)
        Me.tsbPopulate.Text = "Populate"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'tbDestination
        '
        Me.tbDestination.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tbDestination.Name = "tbDestination"
        Me.tbDestination.Size = New System.Drawing.Size(250, 27)
        '
        'tsbBrowseDestination
        '
        Me.tsbBrowseDestination.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbBrowseDestination.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbBrowseDestination.Image = CType(resources.GetObject("tsbBrowseDestination.Image"), System.Drawing.Image)
        Me.tsbBrowseDestination.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBrowseDestination.Name = "tsbBrowseDestination"
        Me.tsbBrowseDestination.Size = New System.Drawing.Size(89, 24)
        Me.tsbBrowseDestination.Text = "Destination"
        '
        'tsbMove
        '
        Me.tsbMove.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbMove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbMove.Image = CType(resources.GetObject("tsbMove.Image"), System.Drawing.Image)
        Me.tsbMove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMove.Name = "tsbMove"
        Me.tsbMove.Size = New System.Drawing.Size(50, 24)
        Me.tsbMove.Text = "Move"
        '
        'ssMain
        '
        Me.ssMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ssMain.Location = New System.Drawing.Point(0, 373)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Size = New System.Drawing.Size(1024, 22)
        Me.ssMain.TabIndex = 1
        Me.ssMain.Text = "StatusStrip1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 27)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lvLeft)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ssLeft)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lvRight)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ssRight)
        Me.SplitContainer1.Size = New System.Drawing.Size(1024, 346)
        Me.SplitContainer1.SplitterDistance = 524
        Me.SplitContainer1.TabIndex = 2
        '
        'lvLeft
        '
        Me.lvLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvLeft.Location = New System.Drawing.Point(0, 0)
        Me.lvLeft.Name = "lvLeft"
        Me.lvLeft.Size = New System.Drawing.Size(524, 321)
        Me.lvLeft.TabIndex = 1
        Me.lvLeft.UseCompatibleStateImageBehavior = False
        '
        'ssLeft
        '
        Me.ssLeft.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ssLeft.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsStatusLeftText})
        Me.ssLeft.Location = New System.Drawing.Point(0, 321)
        Me.ssLeft.Name = "ssLeft"
        Me.ssLeft.Size = New System.Drawing.Size(524, 25)
        Me.ssLeft.TabIndex = 0
        Me.ssLeft.Text = "StatusStrip2"
        '
        'lvRight
        '
        Me.lvRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRight.Location = New System.Drawing.Point(0, 0)
        Me.lvRight.Name = "lvRight"
        Me.lvRight.Size = New System.Drawing.Size(496, 321)
        Me.lvRight.TabIndex = 1
        Me.lvRight.UseCompatibleStateImageBehavior = False
        '
        'ssRight
        '
        Me.ssRight.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ssRight.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbStatusRightText})
        Me.ssRight.Location = New System.Drawing.Point(0, 321)
        Me.ssRight.Name = "ssRight"
        Me.ssRight.Size = New System.Drawing.Size(496, 25)
        Me.ssRight.TabIndex = 0
        Me.ssRight.Text = "StatusStrip3"
        '
        'tsStatusLeftText
        '
        Me.tsStatusLeftText.Name = "tsStatusLeftText"
        Me.tsStatusLeftText.Size = New System.Drawing.Size(153, 20)
        Me.tsStatusLeftText.Text = "ToolStripStatusLabel1"
        '
        'tbStatusRightText
        '
        Me.tbStatusRightText.Name = "tbStatusRightText"
        Me.tbStatusRightText.Size = New System.Drawing.Size(153, 20)
        Me.tbStatusRightText.Text = "ToolStripStatusLabel2"
        '
        'tbCutoff
        '
        Me.tbCutoff.Name = "tbCutoff"
        Me.tbCutoff.Size = New System.Drawing.Size(100, 27)
        '
        'tsbPlusMinus
        '
        Me.tsbPlusMinus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbPlusMinus.Image = CType(resources.GetObject("tsbPlusMinus.Image"), System.Drawing.Image)
        Me.tsbPlusMinus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPlusMinus.Name = "tsbPlusMinus"
        Me.tsbPlusMinus.Size = New System.Drawing.Size(52, 24)
        Me.tsbPlusMinus.Text = "Minus"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 395)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ssMain)
        Me.Controls.Add(Me.tsMain)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ssLeft.ResumeLayout(False)
        Me.ssLeft.PerformLayout()
        Me.ssRight.ResumeLayout(False)
        Me.ssRight.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsMain As ToolStrip
    Friend WithEvents tsbBrowseSource As ToolStripButton
    Friend WithEvents tbSource As ToolStripTextBox
    Friend WithEvents tsbPopulate As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tbDestination As ToolStripTextBox
    Friend WithEvents tsbBrowseDestination As ToolStripButton
    Friend WithEvents tsbMove As ToolStripButton
    Friend WithEvents ssMain As StatusStrip
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lvLeft As ListView
    Friend WithEvents ssLeft As StatusStrip
    Friend WithEvents lvRight As ListView
    Friend WithEvents ssRight As StatusStrip
    Friend WithEvents tsStatusLeftText As ToolStripStatusLabel
    Friend WithEvents tbStatusRightText As ToolStripStatusLabel
    Friend WithEvents tbCutoff As ToolStripTextBox
    Friend WithEvents tsbPlusMinus As ToolStripButton
End Class
