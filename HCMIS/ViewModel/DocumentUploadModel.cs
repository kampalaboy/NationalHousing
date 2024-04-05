using HCMIS.Data;
using HCMIS.Model;
using System.Net.Http.Headers;
using System.Text.Json;

namespace HCMIS.ViewModel
{
    public class DocumentUploadModel
    {
        private readonly ApiConfig _ApiConfig;
        private readonly HttpClient Http;
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public DocumentUploadModel(ApiConfig apiConfig,
            HttpClient http)
        {
            this._ApiConfig = apiConfig;
            this.Http = http;
        }
        public async Task<Response> SaveDocument(ImageUpload inputmodel, string? AccessToken)
        {
            Response? _response = new();
            try
            {
                Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",AccessToken);
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(inputmodel);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await Http.PostAsync($"{_ApiConfig.BaseUrl}NonStaff/SaveDocumentUpload", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    _response = JsonSerializer.Deserialize<Response>(content, _options);
                }
                else
                {
                    _response= new();
                    _response.IsSuccess = false;
                    _response.Message = $"Error: {result.ReasonPhrase}";
                    _response.Status = "Error";
                }
            }
            catch (Exception ex)
            {
                _response = new();
                _response.IsSuccess = false;
                _response.Message = $"Error: {ex.Message}";
                _response.Status = "Error";
            }
            return _response;
        }
        public async Task<ImageUpload> GetDocument(string? DocName, string? Rootfolder, string? AccessToken)
        {
            ImageUpload? imageUpload = new();
            try
            {
                Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",AccessToken);
                var response = await Http.GetAsync($"{_ApiConfig.BaseUrl}NonStaff/DocumentUpload/{DocName}/{Rootfolder}");
                var content = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    imageUpload = JsonSerializer.Deserialize<ImageUpload>(content, _options);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return imageUpload;
        }
    }
}
