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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnBeMeanToMe = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AGE GAME INSULT GENERATOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Your Age"
        '
        'txtUserInput
        '
        Me.txtUserInput.Location = New System.Drawing.Point(174, 82)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(103, 20)
        Me.txtUserInput.TabIndex = 2
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(174, 124)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(102, 20)
        Me.lblResult.TabIndex = 3
        '
        'btnBeMeanToMe
        '
        Me.btnBeMeanToMe.Location = New System.Drawing.Point(173, 176)
        Me.btnBeMeanToMe.Name = "btnBeMeanToMe"
        Me.btnBeMeanToMe.Size = New System.Drawing.Size(90, 25)
        Me.btnBeMeanToMe.TabIndex = 4
        Me.btnBeMeanToMe.Text = "Be Mean To Me"
        Me.btnBeMeanToMe.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(47, 178)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 22)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 257)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBeMeanToMe)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUserInput As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnBeMeanToMe As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
