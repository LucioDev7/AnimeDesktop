using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAnime.ClassAux
{
    public static class Prompt
    {
        // Método estático para mostrar un cuadro de diálogo de entrada de texto
        public static string ShowDialog(string text, string caption)
        {
            // Crea una nueva ventana de formulario para el cuadro de diálogo
            Form prompt = new Form()
            {
                Width = 400,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            // Crea una etiqueta y un cuadro de texto en la ventana de formulario
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 300 };

            // Crea un botón de confirmación "Ok"
            Button confirmation = new Button() { Text = "Ok", Left = 250, Width = 100, Top = 70, DialogResult = DialogResult.OK };

            // Asocia un evento al clic del botón de confirmación para cerrar el cuadro de diálogo
            confirmation.Click += (sender, e) => { prompt.Close(); };

            // Agrega los controles (etiqueta, cuadro de texto y botón de confirmación) a la ventana de formulario
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);

            // Establece el botón predeterminado de aceptación del cuadro de diálogo
            prompt.AcceptButton = confirmation;

            // Muestra el cuadro de diálogo y devuelve el texto ingresado por el usuario
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }

}
