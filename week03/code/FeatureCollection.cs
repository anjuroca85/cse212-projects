public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    //A feature  map with its properties like place and magnitude.
    public List<Feature> Features {get; set;} = [];
}
public class Feature
{
    public EarthquakeProperties Properties {get; set;} = new();
}

public class EarthquakeProperties
{
    public string Place {get; set;} = "";
    public double Mag {get; set;}
}