using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SlateUpdater : MonoBehaviour
{
    public TextMeshPro proyectoText; // Reference to the TextMeshPro component for the Proyecto column
    public TextMeshPro asignacionText; // Reference to the TextMeshPro component for the Asigancion column
    public TextMeshPro tarjetaGraficaText; // Reference to the TextMeshPro component for the Tarjeta Grafica column
    public TextMeshPro memoriaText; // Reference to the TextMeshPro component for the Memoria column
    public TextMeshPro almacenamientoText; // Reference to the TextMeshPro component for the Almacenamiento column
    public TextMeshPro procesadorText; // Reference to the TextMeshPro component for the Procesador column
    public TextMeshPro monitorText; // Reference to the TextMeshPro component for the Monitor column
    public TextMeshPro tecladoText; // Reference to the TextMeshPro component for the Teclado column
    public TextMeshPro mouseText; // Reference to the TextMeshPro component for the Mouse column
    public TextMeshPro soText; // Reference to the TextMeshPro component for the SO column
    public TextMeshPro swRelevanteText; // Reference to the TextMeshPro component for SW Relevante Instalado column
    public TextMeshPro mantenimientoText; // Reference to the TextMeshPro component for the Mantenimiento column
    public CSVReader csvReader; // Reference to the CSVReader script
    public TextMeshPro headerText; // Reference to the desk number
    public int computerIndex; // Index of the computer this slate corresponds to

    private void Start()
    {
        UpdateTitleText();
    }

    private void UpdateTitleText()
    {
        // Access the CSV data from the CSVReader script
        var computerDataList = csvReader.computerDataList; // Get the list of computer data

        // Check if there's data in the list
        //Debug.Log("DataList: " + computerDataList);
        if (computerDataList != null && computerDataList.Count >= computerIndex)
        {
            var computerData = computerDataList[computerIndex];
            var proyectoCargo = computerData.ProyectoCargo;
            var asignacion = computerData.Asignacion;
            var tarjetaGrafica = computerData.TarjetaGrafica;
            var memoria = computerData.Memoria;
            var almacenamiento = computerData.Almacenamiento;
            var procesador = computerData.Procesador;
            var monitor = computerData.Monitor;
            var teclado = computerData.Teclado;
            var mouse = computerData.Mouse;
            var so = computerData.SO;
            var swRelevante = computerData.SWRelevanteInstalado;
            var mantenimiento = computerData.Mantenimiento;
            //Debug.Log("Header: " + headerText.text);

            // Get the computer data for this slate's computer


            // Assuming this slate corresponds to the computer at computerIndex

            Debug.Log("Proyecto/Cargo: " + proyectoCargo);

            // Update the title TextMeshPro with the relevant data
            proyectoText.text = proyectoCargo; // Update with the appropriate property
            asignacionText.text = asignacion; // Update with the appropriate property
            tarjetaGraficaText.text = tarjetaGrafica; // Update with the appropriate property
            memoriaText.text = memoria; // Update with the appropriate property
            almacenamientoText.text = almacenamiento; // Update with the appropriate property
            procesadorText.text = procesador; // Update with the appropriate property
            monitorText.text = monitor; // Update with the appropriate property
            tecladoText.text = teclado; // Update with the appropriate property
            mouseText.text = mouse; // Update with the appropriate property
            soText.text = so; // Update with the appropriate property
            swRelevanteText.text = swRelevante; // Update with the appropriate property
            mantenimientoText.text = mantenimiento; // Update with the appropriate property


        }
        else
        {
            // Handle the case where no data is available (e.g., show an error message)
            proyectoText.text = "No Data Available";
            asignacionText.text = "No Data Available"; 
            tarjetaGraficaText.text = "No Data Available"; 
            memoriaText.text = "No Data Available";
            almacenamientoText.text = "No Data Available"; 
            procesadorText.text = "No Data Available"; 
            monitorText.text = "No Data Available";
            tecladoText.text = "No Data Available";
            mouseText.text = "No Data Available"; 
            soText.text = "No Data Available"; 
            swRelevanteText.text = "No Data Available"; 
            mantenimientoText.text = "No Data Available";
        }
    }
}
