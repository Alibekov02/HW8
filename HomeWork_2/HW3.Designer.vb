<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HW3
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.result = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'result
        '
        Me.result.Location = New System.Drawing.Point(473, 12)
        Me.result.Multiline = True
        Me.result.Name = "result"
        Me.result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.result.Size = New System.Drawing.Size(278, 426)
        Me.result.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(143, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Эсепте"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HW3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.result)
        Me.Name = "HW3"
        Me.Text = "3-Тапшырма"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents result As TextBox
    Friend WithEvents Button1 As Button
End Class
