using System.Net.Http;
using System.Text.Json;

namespace API
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }
        public class Pokemon
        {
            public string Name { get; set; }
            public int Height { get; set; }
            public int Weight { get; set; }
            public Sprites Sprites { get; set; }
        }

        public class Sprites
        {
            public string Front_Default { get; set; }
        }

        public class CatImage
        {
            public string Url { get; set; }
        }
        private async void btnConsulta_Click(object sender, EventArgs e)
        {
            string query = txtBusqueda.Text.Trim();
            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Por favor, ingrese un término de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Llamadas a ambas APIs
                var pokemonTask = ObtenerDatosPokemon(query);
                //var gatoTask = ObtenerImagenGato();

                //await Task.WhenAll(pokemonTask, gatoTask);

                // Mostrar resultados
                MostrarDatosPokemon(await pokemonTask);
                //MostrarImagenGato(await gatoTask);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<Pokemon> ObtenerDatosPokemon(string nombre)
        {
            string url = $"https://pokeapi.co/api/v2/pokemon/{nombre.ToLower()}";
            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                throw new Exception("No se encontró el Pokémon.");

            string json = await response.Content.ReadAsStringAsync();
            Console.WriteLine(json); // Imprime el JSON en la consola para depuración
            return JsonSerializer.Deserialize<Pokemon>(json);
        }

        private async Task<CatImage> ObtenerImagenGato()
        {
            string url = "https://api.thecatapi.com/v1/images/search?api_key=live_gdppisoG6etXcKRbaVmiSzAcPDz2NsVbPlKqs4A377XbWulSCk6NaPF8DqekpSq0";
            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                throw new Exception("No se pudo obtener la imagen del gato.");

            string json = await response.Content.ReadAsStringAsync();
            var datos = JsonSerializer.Deserialize<List<CatImage>>(json);
            return datos[0]; // La API devuelve un array con un solo objeto
        }

        private void MostrarDatosPokemon(Pokemon datos)
        {
            lblNombre.Text = $"Nombre: {datos.Name}";
            lblAltura.Text = $"Altura: {datos.Height}";
            lblPeso.Text = $"Peso: {datos.Weight}";

            if (datos.Sprites != null && !string.IsNullOrEmpty(datos.Sprites.Front_Default))
            {
                pictureBox1.ImageLocation = datos.Sprites.Front_Default; // Establece la URL de la imagen
            }
            else
            {
                pictureBox1.Image = null; // Limpia la imagen si no hay sprite disponible
                MessageBox.Show("El Pokémon no tiene una imagen disponible.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MostrarImagenGato(CatImage datos)
        {

            if (!string.IsNullOrEmpty(datos.Url))
            {
                pictureBox1.ImageLocation = datos.Url; // Establece la URL de la imagen
            }
            else
            {
                pictureBox1.Image = null; // Limpia la imagen si no hay URL disponible
                MessageBox.Show("No se pudo cargar la imagen del gato.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            lblNombre.Text = lblAltura.Text = lblPeso.Text = string.Empty;
            pictureBox1.Image = null;
            pictureBox1.Image = null;
        }
    }
}
