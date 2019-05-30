using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
{
    class Support
    {
        public bool IsStringEmpty(string line)
        {
            return String.IsNullOrEmpty(line) | String.IsNullOrWhiteSpace(line);
        }
        public void ShowMistake(string content = "Поля должны быть заполнены", string header = "Ошибка")
        {
            MessageBox.Show(content, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public string IdentifyType(object individual)
        {
            string type = "";
            if (individual is KingdomAnimal)
            {
                type = "animal";
            }
            if (individual is ClassBirds)
            {
                type = "birds";
            }
            if (individual is ClassMammals)
            {
                type = "mammals";
            }
            if (individual is OrderArtiodactyl)
            {
                type = "artyodactyl";
            }
            return type;
        }
        public void ShowInfo(string content)
        {
            string header = "Успех";
            MessageBox.Show(content, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
