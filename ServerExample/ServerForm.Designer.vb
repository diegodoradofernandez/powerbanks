<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerForm
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.PortTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.StartStopButton = New System.Windows.Forms.ToolStripButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ConnectionCountLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tercerbyte = New System.Windows.Forms.TextBox()
        Me.cuartobyte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.segundobyte = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.quintobyte = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.PortTextBox, Me.StartStopButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(4, 0, 1, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(928, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripLabel1.Text = "Puerto"
        '
        'PortTextBox
        '
        Me.PortTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PortTextBox.Name = "PortTextBox"
        Me.PortTextBox.Size = New System.Drawing.Size(64, 25)
        Me.PortTextBox.Text = "9080"
        Me.PortTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StartStopButton
        '
        Me.StartStopButton.CheckOnClick = True
        Me.StartStopButton.Image = Global.WindowsApplication1.My.Resources.Resources.StartServer
        Me.StartStopButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StartStopButton.Name = "StartStopButton"
        Me.StartStopButton.Size = New System.Drawing.Size(62, 22)
        Me.StartStopButton.Text = "Iniciar"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 25)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(640, 317)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectionCountLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 382)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(928, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ConnectionCountLabel
        '
        Me.ConnectionCountLabel.Name = "ConnectionCountLabel"
        Me.ConnectionCountLabel.Size = New System.Drawing.Size(78, 17)
        Me.ConnectionCountLabel.Text = "0 Conexiones"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(656, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(249, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Enviar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tercerbyte
        '
        Me.tercerbyte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tercerbyte.Location = New System.Drawing.Point(721, 25)
        Me.tercerbyte.MaxLength = 2
        Me.tercerbyte.Name = "tercerbyte"
        Me.tercerbyte.Size = New System.Drawing.Size(50, 25)
        Me.tercerbyte.TabIndex = 7
        '
        'cuartobyte
        '
        Me.cuartobyte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cuartobyte.Location = New System.Drawing.Point(789, 25)
        Me.cuartobyte.MaxLength = 2
        Me.cuartobyte.Name = "cuartobyte"
        Me.cuartobyte.Size = New System.Drawing.Size(47, 25)
        Me.cuartobyte.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(721, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "3º byte"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(786, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "4º byte"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(499, 350)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(653, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "2º byte"
        '
        'segundobyte
        '
        Me.segundobyte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.segundobyte.Location = New System.Drawing.Point(653, 25)
        Me.segundobyte.MaxLength = 2
        Me.segundobyte.Name = "segundobyte"
        Me.segundobyte.Size = New System.Drawing.Size(50, 25)
        Me.segundobyte.TabIndex = 12
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(656, 138)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(249, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Get ID"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(855, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "5º byte"
        '
        'quintobyte
        '
        Me.quintobyte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.quintobyte.Location = New System.Drawing.Point(858, 25)
        Me.quintobyte.MaxLength = 2
        Me.quintobyte.Name = "quintobyte"
        Me.quintobyte.Size = New System.Drawing.Size(47, 25)
        Me.quintobyte.TabIndex = 15
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(656, 217)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(249, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "HearBeat"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(656, 176)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(249, 23)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Aceptar conexión"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(656, 267)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(249, 23)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Comando Gavin"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ServerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 404)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.quintobyte)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.segundobyte)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cuartobyte)
        Me.Controls.Add(Me.tercerbyte)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ServerForm"
        Me.Text = "Server"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PortTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents StartStopButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ConnectionCountLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents tercerbyte As TextBox
    Friend WithEvents cuartobyte As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents segundobyte As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents quintobyte As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
