using System.ComponentModel.DataAnnotations;

namespace RoadCalculator.Models;

public class CalcularDistanciasModel
{
    [Range(1, double.MaxValue, ErrorMessage = "El valor de {0} debe ser mayor a {1}")]
    public double PrecioAlquilerMaquina { get; set; }
}
