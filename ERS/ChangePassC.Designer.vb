﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassC
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ne1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtp = New System.Windows.Forms.TextBox()
        Me.pw = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(154, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 28)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Change Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ne1
        '
        Me.ne1.AutoSize = True
        Me.ne1.Location = New System.Drawing.Point(197, 93)
        Me.ne1.Name = "ne1"
        Me.ne1.Size = New System.Drawing.Size(39, 13)
        Me.ne1.TabIndex = 11
        Me.ne1.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Retype Newpass:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "NewPassword:"
        '
        'rtp
        '
        Me.rtp.Location = New System.Drawing.Point(140, 44)
        Me.rtp.Name = "rtp"
        Me.rtp.Size = New System.Drawing.Size(146, 20)
        Me.rtp.TabIndex = 7
        '
        'pw
        '
        Me.pw.Location = New System.Drawing.Point(140, 13)
        Me.pw.Name = "pw"
        Me.pw.Size = New System.Drawing.Size(146, 20)
        Me.pw.TabIndex = 6
        '
        'ChangePassC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 116)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ne1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtp)
        Me.Controls.Add(Me.pw)
        Me.Name = "ChangePassC"
        Me.Text = "ChangePassC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ne1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rtp As System.Windows.Forms.TextBox
    Friend WithEvents pw As System.Windows.Forms.TextBox
End Class
