<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblProblema = New System.Windows.Forms.Label()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.BtnVerificar = New System.Windows.Forms.Button()
        Me.pnltop = New System.Windows.Forms.Panel()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnminimizar = New System.Windows.Forms.Button()
        Me.lblmaintxt = New System.Windows.Forms.Label()
        Me.pnltop.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProblema
        '
        Me.lblProblema.AutoSize = True
        Me.lblProblema.Font = New System.Drawing.Font("Ebrima", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProblema.Location = New System.Drawing.Point(202, 77)
        Me.lblProblema.Name = "lblProblema"
        Me.lblProblema.Size = New System.Drawing.Size(142, 37)
        Me.lblProblema.TabIndex = 0
        Me.lblProblema.Text = "Problema"
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespuesta.Location = New System.Drawing.Point(76, 130)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(397, 42)
        Me.txtRespuesta.TabIndex = 1
        '
        'BtnVerificar
        '
        Me.BtnVerificar.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerificar.Location = New System.Drawing.Point(171, 203)
        Me.BtnVerificar.Name = "BtnVerificar"
        Me.BtnVerificar.Size = New System.Drawing.Size(202, 56)
        Me.BtnVerificar.TabIndex = 2
        Me.BtnVerificar.Text = "Verificar"
        Me.BtnVerificar.UseVisualStyleBackColor = True
        '
        'pnltop
        '
        Me.pnltop.BackColor = System.Drawing.Color.Firebrick
        Me.pnltop.Controls.Add(Me.lblmaintxt)
        Me.pnltop.Controls.Add(Me.btncerrar)
        Me.pnltop.Controls.Add(Me.btnminimizar)
        Me.pnltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnltop.Location = New System.Drawing.Point(0, 0)
        Me.pnltop.Name = "pnltop"
        Me.pnltop.Size = New System.Drawing.Size(576, 45)
        Me.pnltop.TabIndex = 3
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackgroundImage = Global.MathGame2.My.Resources.Resources.CROSS_1
        Me.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Location = New System.Drawing.Point(520, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(56, 45)
        Me.btncerrar.TabIndex = 5
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnminimizar
        '
        Me.btnminimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnminimizar.BackgroundImage = Global.MathGame2.My.Resources.Resources._211863_minus_round_icon
        Me.btnminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnminimizar.FlatAppearance.BorderSize = 0
        Me.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimizar.Location = New System.Drawing.Point(456, 0)
        Me.btnminimizar.Name = "btnminimizar"
        Me.btnminimizar.Size = New System.Drawing.Size(56, 45)
        Me.btnminimizar.TabIndex = 4
        Me.btnminimizar.UseVisualStyleBackColor = True
        '
        'lblmaintxt
        '
        Me.lblmaintxt.AutoSize = True
        Me.lblmaintxt.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaintxt.ForeColor = System.Drawing.Color.LightGray
        Me.lblmaintxt.Location = New System.Drawing.Point(5, 3)
        Me.lblmaintxt.Name = "lblmaintxt"
        Me.lblmaintxt.Size = New System.Drawing.Size(208, 37)
        Me.lblmaintxt.TabIndex = 4
        Me.lblmaintxt.Text = "ProblemSolver"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 305)
        Me.Controls.Add(Me.pnltop)
        Me.Controls.Add(Me.BtnVerificar)
        Me.Controls.Add(Me.txtRespuesta)
        Me.Controls.Add(Me.lblProblema)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnltop.ResumeLayout(False)
        Me.pnltop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProblema As Label
    Friend WithEvents txtRespuesta As TextBox
    Friend WithEvents BtnVerificar As Button
    Friend WithEvents pnltop As Panel
    Friend WithEvents btncerrar As Button
    Friend WithEvents btnminimizar As Button
    Friend WithEvents lblmaintxt As Label
End Class
