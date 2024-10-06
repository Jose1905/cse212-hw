using System.Text.Json;

public class FeatureCollection
{
    private string _json;
    private JsonSerializerOptions _options;

    public FeatureCollection(string json, JsonSerializerOptions options)
    {
        _json = json;
        _options = options;
    }

    public string GetJson()
    {
        return _json;
    }

    public void SetJson(string json)
    {
        _json = json;
    }

    public JsonSerializerOptions GetOptions()
    {
        return _options;
    }

    public void SetOptions(JsonSerializerOptions options)
    {
        _options = options;
    }
}

public class Earthquake
{
    private string _place;
    private float _magnitude;

    public Earthquake(string place, float magnitude)
    {
        string _place = place;
        float _magnitude = magnitude;
    }

    public string GetPlace()
    {
        return _place;
    }

    public void SetPlace(string place)
    {
        _place = place;
    }

    public float GetMagnitude()
    {
        return _magnitude;
    }

    public void SetMagnitude(float magnitude)
    {
        _magnitude = magnitude;
    }

}