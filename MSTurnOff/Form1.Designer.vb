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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.shutdownbutton = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.restartbutton = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.standbybutton = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shutdownbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.restartbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.standbybutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(241, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 21)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(265, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 40)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Turn off computer"
        '
        'shutdownbutton
        '
        Me.shutdownbutton.BackColor = System.Drawing.Color.Transparent
        Me.shutdownbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.shutdownbutton.Image = Global.RoterinoGina.My.Resources.Resources.shutdownnormal
        Me.shutdownbutton.Location = New System.Drawing.Point(141, 80)
        Me.shutdownbutton.Name = "shutdownbutton"
        Me.shutdownbutton.Size = New System.Drawing.Size(32, 32)
        Me.shutdownbutton.TabIndex = 3
        Me.shutdownbutton.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(130, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Turn Off"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(215, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Restart"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'restartbutton
        '
        Me.restartbutton.BackColor = System.Drawing.Color.Transparent
        Me.restartbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.restartbutton.Image = Global.RoterinoGina.My.Resources.Resources.restartnormal
        Me.restartbutton.Location = New System.Drawing.Point(226, 80)
        Me.restartbutton.Name = "restartbutton"
        Me.restartbutton.Size = New System.Drawing.Size(32, 32)
        Me.restartbutton.TabIndex = 5
        Me.restartbutton.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(39, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Stand By"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'standbybutton
        '
        Me.standbybutton.BackColor = System.Drawing.Color.Transparent
        Me.standbybutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.standbybutton.Image = Global.RoterinoGina.My.Resources.Resources.standbynormal
        Me.standbybutton.Location = New System.Drawing.Point(55, 80)
        Me.standbybutton.Name = "standbybutton"
        Me.standbybutton.Size = New System.Drawing.Size(32, 32)
        Me.standbybutton.TabIndex = 7
        Me.standbybutton.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.RoterinoGina.My.Resources.Resources.turnoffbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(313, 198)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.standbybutton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.restartbutton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.shutdownbutton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turn off computer"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shutdownbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.restartbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.standbybutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents shutdownbutton As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents restartbutton As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents standbybutton As PictureBox
End Class
