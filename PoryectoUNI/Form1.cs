using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using GMap.NET.MapProviders;

namespace PoryectoUNI
{
    public partial class Form1 : Form
    {
        private GMapControl gmap;
        public Form1()
        {
            InitializeComponent();
            InicializarMapaEnTacna();
        }

        private void InicializarMapaEnTacna()
        {
            // Inicializar el mapa
            gmap = new GMapControl();
            gmap.Dock = DockStyle.Fill;
            gmap.Name = "gmap";
            gmap.Bearing = 0;
            gmap.CanDragMap = true;
            gmap.DragButton = MouseButtons.Left;
            gmap.EmptyTileColor = Color.Navy;
            gmap.GrayScaleMode = false;
            gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gmap.LevelsKeepInMemmory = 5;
            gmap.MarkersEnabled = true;
            gmap.MaxZoom = 20;
            gmap.MinZoom = 1;
            gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gmap.NegativeMode = false;
            gmap.PolygonsEnabled = true;
            gmap.RetryLoadTile = 0;
            gmap.RoutesEnabled = true;
            gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gmap.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gmap.ShowTileGridLines = false;
            gmap.Zoom = 17;
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            // Coordenadas Plaza de Tacna, Perú
            gmap.Position = new GMap.NET.PointLatLng(-18.013728, -70.251890);

            // Limpiar y agregar el control al panelMapa
            panelMapa.Controls.Clear();
            panelMapa.Controls.Add(gmap);

            // Agregar marcador en Plaza de Tacna
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(new PointLatLng(-18.013728, -70.251890), GMarkerGoogleType.red_dot);
            marker.ToolTipText = "Plaza de Tacna";
            markers.Markers.Add(marker);
            gmap.Overlays.Add(markers);
        }

        private void btnBuscarRuta_Click(object sender, EventArgs e)
        {
            // Aquí va la lógica para buscar rutas
        }

        private void btnRegistrarRuta_Click(object sender, EventArgs e)
        {
            // Aquí va la lógica para registrar rutas
        }
    }
}
