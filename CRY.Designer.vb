<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRY))
        Me.mnC = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn = New System.Windows.Forms.MenuStrip()
        Me.mnD = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCr = New System.Windows.Forms.RichTextBox()
        Me.mn.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnC
        '
        Me.mnC.Name = "mnC"
        Me.mnC.Size = New System.Drawing.Size(83, 20)
        Me.mnC.Text = "&Criptografar"
        '
        'mn
        '
        Me.mn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnC, Me.mnD})
        Me.mn.Location = New System.Drawing.Point(0, 0)
        Me.mn.Name = "mn"
        Me.mn.Size = New System.Drawing.Size(294, 24)
        Me.mn.TabIndex = 1
        Me.mn.Text = "MenuStrip1"
        '
        'mnD
        '
        Me.mnD.Name = "mnD"
        Me.mnD.Size = New System.Drawing.Size(100, 20)
        Me.mnD.Text = "&Descriptografar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtCr)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 237)
        Me.Panel1.TabIndex = 2
        '
        'txtCr
        '
        Me.txtCr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCr.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCr.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtCr.Location = New System.Drawing.Point(0, 0)
        Me.txtCr.Name = "txtCr"
        Me.txtCr.Size = New System.Drawing.Size(294, 237)
        Me.txtCr.TabIndex = 0
        Me.txtCr.Text = ""
        '
        'CRY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 261)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.mn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mn
        Me.Name = "CRY"
        Me.Text = "Criptografia"
        Me.mn.ResumeLayout(False)
        Me.mn.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mn As System.Windows.Forms.MenuStrip
    Friend WithEvents mnD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCr As System.Windows.Forms.RichTextBox

End Class
