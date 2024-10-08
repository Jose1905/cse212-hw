public class FeatureCollection
{
    public string Type {get; set; }
    public Metadata Metadata {get; set; } 
    public Feature[] Features {get; set; }
    public float[] Bbox {get; set; }
}

class Metadata{
    public long Generated {get; set; }
    public string Url {get; set; }
    public string Title {get; set; }
    public int Status {get; set; }
    public string Api {get; set; }
    public int Count {get; set; }
}

class Feature
{
    public string Type {get; set; }
    public Properties Properties {get; set; }
    public Geometry Geometry {get; set; }
    public string Id {get; set; }
}

class Properties
{
    public float Magnitude {get; set; }
    public string Place {get; set; }
    public long Time {get; set; }
    public long Updated {get; set; }
    public bool? Tz {get; set; }
    public string Url {get; set; }
    public string Detail {get; set; }
    public bool? Felt {get; set; }
    public bool? Cdi {get; set; }
    public bool? Mmi {get; set; }
    public bool? Alert {get; set; }
    public string Status {get; set; }
    public int Tsunami {get; set; }
    public int Sig {get; set; }
    public string Net {get; set; }
    public string Code {get; set; }
    public string Ids {get; set; }
    public string Sources {get; set; }
    public string Types {get; set; }
    public int Nst {get; set; }
    public double Dmin {get; set; }
    public float Rms {get; set; }
    public int Gap {get; set; }
    public string MagType {get; set; }
    public string Type {get; set; }
    public string Title {get; set; }
}

class Geometry
{
    public string Type {get; set; }
    public double[] coordinates {get; set; }
}