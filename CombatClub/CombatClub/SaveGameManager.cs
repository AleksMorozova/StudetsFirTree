using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.IO;

namespace CombatClub
{
    class SaveGameManager
    {
        static public void SaveProcGame(Presenter presenter)
        {      
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            
            saveFileDialog.FileName = "game.dat";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream FileStream = File.Create(saveFileDialog.FileName);
                BinaryFormatter binFormatSer = new BinaryFormatter();
                binFormatSer.Serialize(FileStream, presenter);
                FileStream.Close();        
            }                        
        }

        static public Presenter LoadGameProc()
        {            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = File.OpenRead(openFileDialog.FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                try
                {
                    return (Presenter)deserializer.Deserialize(fileStream);                    
                }
                catch
                {
                    MessageBox.Show("Error. Incorrect file");
                    return null;
                }
                fileStream.Close();
            }
            else 
                return null;            
        }        
    }
}
