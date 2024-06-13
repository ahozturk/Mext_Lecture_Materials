namespace App.Domain.ValueObjects;

public record class Camera
{
    public Camera(decimal resolution, decimal diafram, decimal focalDistance)
    {
        Resolution = resolution;
        Diafram = diafram;
        FocalDistance = focalDistance;
    }

    public decimal Resolution { get; set; }
    public decimal Diafram { get; set; }
    public decimal FocalDistance { get; set; }

}
