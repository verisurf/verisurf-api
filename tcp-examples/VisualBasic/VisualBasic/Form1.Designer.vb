<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Header1 = New System.Windows.Forms.Label()
        Me.Command1 = New System.Windows.Forms.LinkLabel()
        Me.Header2 = New System.Windows.Forms.Label()
        Me.Results = New System.Windows.Forms.TextBox()
        Me.Body = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Command = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Command2 = New System.Windows.Forms.LinkLabel()
        Me.Command3 = New System.Windows.Forms.LinkLabel()
        Me.Command4 = New System.Windows.Forms.LinkLabel()
        Me.Command5 = New System.Windows.Forms.LinkLabel()
        Me.Command6 = New System.Windows.Forms.LinkLabel()
        Me.Command7 = New System.Windows.Forms.LinkLabel()
        Me.Command8 = New System.Windows.Forms.LinkLabel()
        Me.Command9 = New System.Windows.Forms.LinkLabel()
        Me.Command10 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.WindowText
        Me.PictureBox1.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 468)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Header1
        '
        Me.Header1.AutoSize = True
        Me.Header1.BackColor = System.Drawing.Color.Black
        Me.Header1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header1.ForeColor = System.Drawing.Color.Transparent
        Me.Header1.Location = New System.Drawing.Point(30, 20)
        Me.Header1.Name = "Header1"
        Me.Header1.Size = New System.Drawing.Size(182, 37)
        Me.Header1.TabIndex = 1
        Me.Header1.Text = "Commands"
        '
        'Command1
        '
        Me.Command1.ActiveLinkColor = System.Drawing.Color.White
        Me.Command1.AutoSize = True
        Me.Command1.BackColor = System.Drawing.Color.Black
        Me.Command1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Command1.Location = New System.Drawing.Point(35, 80)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(69, 20)
        Me.Command1.TabIndex = 2
        Me.Command1.TabStop = True
        Me.Command1.Text = "Connect"
        Me.Command1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        '
        'Header2
        '
        Me.Header2.AutoSize = True
        Me.Header2.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header2.Location = New System.Drawing.Point(291, 21)
        Me.Header2.Name = "Header2"
        Me.Header2.Size = New System.Drawing.Size(432, 51)
        Me.Header2.TabIndex = 3
        Me.Header2.Text = "Verisurf API Example"
        '
        'Results
        '
        Me.Results.Enabled = False
        Me.Results.Location = New System.Drawing.Point(300, 165)
        Me.Results.Multiline = True
        Me.Results.Name = "Results"
        Me.Results.Size = New System.Drawing.Size(442, 199)
        Me.Results.TabIndex = 4
        '
        'Body
        '
        Me.Body.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Body.Location = New System.Drawing.Point(297, 82)
        Me.Body.Name = "Body"
        Me.Body.Size = New System.Drawing.Size(445, 78)
        Me.Body.TabIndex = 5
        Me.Body.Text = resources.GetString("Body.Text")
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox2.Location = New System.Drawing.Point(300, 375)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(443, 10)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Command
        '
        Me.Command.Location = New System.Drawing.Point(300, 407)
        Me.Command.Name = "Command"
        Me.Command.Size = New System.Drawing.Size(331, 20)
        Me.Command.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(637, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 27)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Send Command"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Command2
        '
        Me.Command2.ActiveLinkColor = System.Drawing.Color.White
        Me.Command2.AutoSize = True
        Me.Command2.BackColor = System.Drawing.Color.Black
        Me.Command2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Command2.Location = New System.Drawing.Point(35, 110)
        Me.Command2.Name = "Command2"
        Me.Command2.Size = New System.Drawing.Size(111, 20)
        Me.Command2.TabIndex = 9
        Me.Command2.TabStop = True
        Me.Command2.Text = "Command List"
        Me.Command2.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        '
        'Command3
        '
        Me.Command3.ActiveLinkColor = System.Drawing.Color.White
        Me.Command3.AutoSize = True
        Me.Command3.BackColor = System.Drawing.Color.Black
        Me.Command3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Command3.Location = New System.Drawing.Point(35, 140)
        Me.Command3.Name = "Command3"
        Me.Command3.Size = New System.Drawing.Size(77, 20)
        Me.Command3.TabIndex = 10
        Me.Command3.TabStop = True
        Me.Command3.Text = "File Open"
        Me.Command3.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        '
        'Command4
        '
        Me.Command4.ActiveLinkColor = System.Drawing.Color.White
        Me.Command4.AutoSize = True
        Me.Command4.BackColor = System.Drawing.Color.Black
        Me.Command4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command4.LinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Command4.Location = New System.Drawing.Point(35, 170)
        Me.Command4.Name = "Command4"
        Me.Command4.Size = New System.Drawing.Size(69, 20)
        Me.Command4.TabIndex = 11
        Me.Command4.TabStop = True
        Me.Command4.Text = "Plan List"
        Me.Command4.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        '
        'Command5
        '
        Me.Command5.ActiveLinkColor = System.Drawing.Color.White
        Me.Command5.AutoSize = True
        Me.Command5.BackColor = System.Drawing.Color.Black
        Me.Command5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command5.LinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Command5.Location = New System.Drawing.Point(35, 200)
        Me.Command5.Name = "Command5"
        Me.Command5.Size = New System.Drawing.Size(80, 20)
        Me.Command5.TabIndex = 12
        Me.Command5.TabStop = True
        Me.Command5.Text = "Plan Load"
        Me.Command5.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        '
        'Command6
        '
        Me.Command6.ActiveLinkColor = System.Drawing.Color.White
        Me.Command6.AutoSize = True
        Me.Command6.BackColor = System.Drawing.Color.Black
        Me.Command6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command6.LinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Command6.Location = New System.Drawing.Point(35, 230)
        Me.Command6.Name = "Command6"
        Me.Command6.Size = New System.Drawing.Size(72, 20)
        Me.Command6.TabIndex = 13
        Me.Command6.TabStop = True
        Me.Command6.Text = "Plan Info"
        Me.Command6.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        '
        'Command7
        '
        Me.Command7.ActiveLinkColor = System.Drawing.Color.White
        Me.Command7.AutoSize = True
        Me.Command7.BackColor = System.Drawing.Color.Black
        Me.Command7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command7.LinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Command7.Location = New System.Drawing.Point(35, 260)
        Me.Command7.Name = "Command7"
        Me.Command7.Size = New System.Drawing.Size(121, 20)
        Me.Command7.TabIndex = 14
        Me.Command7.TabStop = True
        Me.Command7.Text = "Object Measure"
        Me.Command7.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        '
        'Command8
        '
        Me.Command8.ActiveLinkColor = System.Drawing.Color.White
        Me.Command8.AutoSize = True
        Me.Command8.BackColor = System.Drawing.Color.Black
        Me.Command8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command8.LinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Command8.Location = New System.Drawing.Point(35, 290)
        Me.Command8.Name = "Command8"
        Me.Command8.Size = New System.Drawing.Size(87, 20)
        Me.Command8.TabIndex = 15
        Me.Command8.TabStop = True
        Me.Command8.Text = "Object Info"
        Me.Command8.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        '
        'Command9
        '
        Me.Command9.ActiveLinkColor = System.Drawing.Color.White
        Me.Command9.AutoSize = True
        Me.Command9.BackColor = System.Drawing.Color.Black
        Me.Command9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command9.LinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Command9.Location = New System.Drawing.Point(35, 320)
        Me.Command9.Name = "Command9"
        Me.Command9.Size = New System.Drawing.Size(74, 20)
        Me.Command9.TabIndex = 16
        Me.Command9.TabStop = True
        Me.Command9.Text = "File Save"
        Me.Command9.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        '
        'Command10
        '
        Me.Command10.ActiveLinkColor = System.Drawing.Color.White
        Me.Command10.AutoSize = True
        Me.Command10.BackColor = System.Drawing.Color.Black
        Me.Command10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command10.LinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Command10.Location = New System.Drawing.Point(35, 350)
        Me.Command10.Name = "Command10"
        Me.Command10.Size = New System.Drawing.Size(89, 20)
        Me.Command10.TabIndex = 17
        Me.Command10.TabStop = True
        Me.Command10.Text = "Disconnect"
        Me.Command10.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Command10)
        Me.Controls.Add(Me.Command9)
        Me.Controls.Add(Me.Command8)
        Me.Controls.Add(Me.Command7)
        Me.Controls.Add(Me.Command6)
        Me.Controls.Add(Me.Command5)
        Me.Controls.Add(Me.Command4)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Command)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Body)
        Me.Controls.Add(Me.Results)
        Me.Controls.Add(Me.Header2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Header1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Verisurf API Example"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Header1 As System.Windows.Forms.Label
    Friend WithEvents Command1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Header2 As System.Windows.Forms.Label
    Friend WithEvents Results As System.Windows.Forms.TextBox
    Friend WithEvents Body As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Command As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Command2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Command3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Command4 As System.Windows.Forms.LinkLabel
    Friend WithEvents Command5 As System.Windows.Forms.LinkLabel
    Friend WithEvents Command6 As System.Windows.Forms.LinkLabel
    Friend WithEvents Command7 As System.Windows.Forms.LinkLabel
    Friend WithEvents Command8 As System.Windows.Forms.LinkLabel
    Friend WithEvents Command9 As System.Windows.Forms.LinkLabel
    Friend WithEvents Command10 As System.Windows.Forms.LinkLabel

End Class
