using System.ComponentModel;
using System.Device.Location;


namespace MedicineDatabase.Pharmacies.Components
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _name;
        private string _distance;
        private string _address;
        private Image _icon;
        //
        private int _id;
        private GeoCoordinate geoCoordinate;
        private List<String> _web;
        private List<String> _email;
        private List<String> _phone;
        private Dictionary<string, string> _hours;
        //private long _cin;      //company identification number
        private string _cin;      //company identification number

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public GeoCoordinate Coordinates
        {
            get { return geoCoordinate; }
            set { geoCoordinate = value; }
        }

        public List<String> Web
        {
            get { return _web; }
            set { _web = value; }
        }

        public List<String> Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public List<String> Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        //public long CIN
        //{
        //    get { return _cin; }
        //    set { _cin = value; }
        //}
        public string CIN
        {
            get { return _cin; }
            set { _cin = value; }
        }

        public Dictionary<string, string> Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }




        [Category("Custom properties")]
        public string Name
        {
            get { return _name; }
            set { _name = value; nameLabel.Text = value; }
        }

        [Category("Custom properties")]
        public string Address
        {
            get { return _address; }
            set { _address = value; addressLabel.Text = value; }
        }

        [Category("Custom properties")]
        public string Distance
        {
            get { return _distance; }
            set { _distance = value; distanceLabel.Text = value; }
        }

        [Category("Custom properties")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }

        #endregion

        public event EventHandler ListItemClick;
        protected void ListItem_Click(object sender, EventArgs e)
        {
            if (this.ListItemClick != null)
            {
                if (sender is not ListItem)
                {
                    this.ListItemClick(this, e);
                }
                else this.ListItemClick(sender, e);
            }
        }

        private void ListItem_Load(object sender, EventArgs e)
        {
            addClikcEvent(this);
        }

        private void addClikcEvent(Control obj)
        {
            foreach (Control c in obj.Controls)
            {
                c.Click += new EventHandler(ListItem_Click);
                if (c is Panel) addClikcEvent(c);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_SizeChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            float scaleFactor = Math.Min((float)label.Width / 237, (float)label.Height / 54);

            float newFontSize = 10F * scaleFactor;

            var newFont = new Font(label.Font.FontFamily.Name, newFontSize);

            label.Font = newFont;
        }

        private void nameLabel_SizeChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            float scaleFactor = Math.Min((float)label.Width / 237, (float)label.Height / 54);

            float newFontSize = 12F * scaleFactor;

            var newFont = new Font(label.Font.FontFamily.Name, newFontSize);

            label.Font = newFont;
        }

        private void ListItem_SizeChanged(object sender, EventArgs e)
        {
            float scaleFactor = Math.Min((float)panel3.Width / 237, (float)nameLabel.Height / 54);
            float newFontSize = 12F * scaleFactor;
            var newFont = new Font(nameLabel.Font.FontFamily.Name, newFontSize);
            nameLabel.Font = newFont;

            scaleFactor = Math.Min((float)panel3.Width / 237, (float)addressLabel.Height / 54);
            newFontSize = 10F * scaleFactor;
            newFont = new Font(addressLabel.Font.FontFamily.Name, newFontSize);
            addressLabel.Font = newFont;

            scaleFactor = Math.Min((float)panel3.Width / 237, (float)distanceLabel.Height / 54);
            newFontSize = 10F * scaleFactor;
            newFont = new Font(distanceLabel.Font.FontFamily.Name, newFontSize);
            distanceLabel.Font = newFont;
        }
    }
}
