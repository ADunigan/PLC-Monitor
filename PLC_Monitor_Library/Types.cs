using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Monitor_Library
{
    public class ProjectFile
    {
        public string OPCServer { get; set; }
        public string OPCTopic { get; set; }
        public List<ServerGroup> GroupNames { get; set; }
    }

    public class ServerGroup
    {
        public string GroupName { get; set; }
        public List<string> TagTypes { get; set; }
        public List<string> TagNames { get; set; }

        public ServerGroup(string name)
        {
            this.GroupName = name;
            this.TagTypes = new List<string>();
            this.TagNames = new List<string>();
        }

        public void AddTag(string tagtype, string tagname)
        {
            if (!this.TagNames.Exists(x => x.Equals(tagname)))
            {
                this.TagTypes.Add(tagtype);
                this.TagNames.Add(tagname);
            }
        }
    }

    public class TAGS
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public TAGS(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        public TAGS(string name)
        {
            this.Name = name;
        }
    }

    public class CheckoutTAGS : INotifyPropertyChanged
    {
        private string nameValue = String.Empty;
        private string valueValue = String.Empty;
        private string tagValue = String.Empty;
        private string aliasValue = String.Empty;
        private string descriptionValue = String.Empty;
        private string statusValue = String.Empty;

        public string Name 
        { 
            get
            {
                return this.nameValue;
            }
            
            set
            {
                if(value != this.Name)
                {
                    this.nameValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Value
        {
            get
            {
                return this.valueValue;
            }

            set
            {
                if (value != this.Value)
                {
                    this.valueValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Tag
        {
            get
            {
                return this.tagValue;
            }

            set
            {
                if (value != this.Tag)
                {
                    this.tagValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Alias
        {
            get
            {
                return this.aliasValue;
            }

            set
            {
                if (value != this.Alias)
                {
                    this.aliasValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Description
        {
            get
            {
                return this.descriptionValue;
            }

            set
            {
                if (value != this.Description)
                {
                    this.descriptionValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Status
        {
            get
            {
                return this.statusValue;
            }

            set
            {
                if (value != this.Status)
                {
                    this.statusValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public CheckoutTAGS(string name, string description, string alias, string tag)
        {
            this.Name = name;
            this.Description = description;
            this.Alias = alias;
            this.Tag = tag;
        }

        public CheckoutTAGS(string name, string description, string alias, string tag, string status)
        {
            this.Name = name;
            this.Description = description;
            this.Alias = alias;
            this.Tag = tag;
            this.Status = status;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] String propName = "")
        {
            if(this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }

    public static class HRESULTS
    {
        public static readonly int BAD_OPC_TOPIC = unchecked((int)0xC004000A);
        public static readonly int BAD_OPC_SERVER = unchecked((int)0x800401F3);
        public static readonly int NO_OPC_TOPIC = unchecked((int)0xC0040007);
        public static readonly int GROUP_ALREADY_EXISTS = unchecked((int)0xC004000C);
        public static readonly int RSLINX_NOT_ACTIVATED;
    }
}
