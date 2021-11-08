using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Zork.Builder.ViewModels 
{
    internal class WorldViewModel : INotifyPropertyChanged
    {
        public BindingList<Room> Rooms { get; set; }

        private World _world;

        private bool IsWorldLoaded;

        public event PropertyChangedEventHandler PropertyChanged;

        public World World
        {
            set
            {
                if (_world != value)
                {
                    _world = value;

                    if (_world != null && _world.Rooms != null)
                    {
                        Rooms = new BindingList<Room>(_world.Rooms);
                    }
                    else if ( _world.Rooms == null )
                    {
                        MessageBox.Show("There are no Rooms in this file, so an empty array of rooms has been created.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public WorldViewModel(World world = null)
        {
            World = world;
        }

        public void SaveWorld(string filename)
        {
            if (!IsWorldLoaded)
            {
                throw new InvalidOperationException("No world loaded.");
            }
            if (string.IsNullOrWhiteSpace(filename))
            {
                throw new InvalidProgramException("Invalid filename.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            
            using (StreamWriter streamWriter = new StreamWriter(filename))       
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, _world);
            }
        }
    }
}
