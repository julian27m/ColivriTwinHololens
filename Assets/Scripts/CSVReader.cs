using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVReader : MonoBehaviour
{
    public string csvFilePath = "Assets/PuestosDeTrabajoColivriPiso120232.csv";
    public List<ComputerData> computerDataList = new List<ComputerData>(); // Store the structured data

    void Start()
    {
        ReadCSVFile(csvFilePath);

        // Now, computerDataList contains structured data from the CSV file

        // Print each entry in the computerDataList to the console
        /*
        foreach (var computerData in computerDataList)
        {
            Debug.Log("Proyecto/Cargo: " + computerData.ProyectoCargo);
            Debug.Log("Asignacion: " + computerData.Asignacion);
            Debug.Log("Tarjeta Grafica: " + computerData.TarjetaGrafica);
            Debug.Log("Memoria: " + computerData.Memoria);
            Debug.Log("Almacenamiento: " + computerData.Almacenamiento);
            Debug.Log("Procesador: " + computerData.Procesador);
            Debug.Log("Monitor: " + computerData.Monitor);
            Debug.Log("Teclado: " + computerData.Teclado);
            Debug.Log("Mouse: " + computerData.Mouse);
            Debug.Log("SO: " + computerData.SO);
            Debug.Log("SW Relevante: " + computerData.SWRelevanteInstalado);
            Debug.Log("Mantenimiento: " + computerData.Mantenimiento);
        }
        */
        
    }

    void ReadCSVFile(string filePath)
{
    try
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            // Skip the header row (column names)
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] row = line.Split(',');

                // Ensure that the row has the expected number of columns
                if (row.Length >= 12)
                {
                    // Create a ComputerData object and populate it with the CSV data
                    ComputerData computerData = new ComputerData
                    {
                        ProyectoCargo = row[0],
                        Asignacion = row[1],
                        TarjetaGrafica = row[2],
                        Memoria = row[3],
                        Almacenamiento = row[4],
                        Procesador = row[5],
                        Monitor = row[6],
                        Teclado = row[7],
                        Mouse = row[8],
                        SO = row[9],
                        SWRelevanteInstalado = row[10],
                        Mantenimiento = row[11]
                    };

                    // Add the ComputerData object to the list
                    computerDataList.Add(computerData);
                }
                else
                {
                    Debug.LogWarning("Skipping row due to insufficient columns: " + line);
                }
            }
        }
    }
    catch (IOException e)
    {
        Debug.LogError("Error reading CSV file: " + e.Message);
    }
}

}

[System.Serializable]
public class ComputerData
{
    public string ProyectoCargo;
    public string Asignacion;
    public string TarjetaGrafica;
    public string Memoria;
    public string Almacenamiento;
    public string Procesador;
    public string Monitor;
    public string Teclado;
    public string Mouse;
    public string SO;
    public string SWRelevanteInstalado;
    public string Mantenimiento;
}
