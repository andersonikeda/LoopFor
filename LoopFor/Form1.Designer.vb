<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.lstLista = New System.Windows.Forms.ListBox()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstLista
        '
        Me.lstLista.FormattingEnabled = True
        Me.lstLista.Location = New System.Drawing.Point(34, 24)
        Me.lstLista.Name = "lstLista"
        Me.lstLista.Size = New System.Drawing.Size(436, 381)
        Me.lstLista.TabIndex = 0
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(505, 38)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(80, 28)
        Me.btnListar.TabIndex = 1
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(505, 72)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(80, 24)
        Me.btnLimpar.TabIndex = 2
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 475)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.lstLista)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstLista As ListBox
    Friend WithEvents btnListar As Button
    Friend WithEvents btnLimpar As Button
End Class
