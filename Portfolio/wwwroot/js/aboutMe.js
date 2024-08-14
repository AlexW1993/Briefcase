document.addEventListener('DOMContentLoaded', () => {
    const ctx = document.getElementById('myChart').getContext('2d');
    const myChart = new Chart(ctx, {
        type: 'pie', // Puedes usar 'line', 'bar', 'pie', etc.
        data: {
            labels: window.chartData.Languages, // Los lenguajes
            datasets: [{
                label: 'Habilidades (0-10)',
                data: window.chartData.Levels, // Porcentajes o niveles de habilidad
                backgroundColor: [
                    'rgba(75, 192, 192, 0.2)',
                    'rgba(153, 102, 255, 0.2)'
                ],
                borderColor: [
                    'rgba(75, 192, 192, 1)',
                    'rgba(153, 102, 255, 1)'
                ],
                borderWidth: 1
            }]
        },
        options: {
            scales: {
                y: {
                    beginAtZero: true,
                    max: 10 // Ajusta según el rango de tus datos
                }
            }
        }
    });
});