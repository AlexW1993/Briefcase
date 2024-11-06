document.addEventListener('DOMContentLoaded', () => {
    const ctx = document.getElementById('languagesChart').getContext('2d');

    const data = {
        Languages: window.chartData.Languages,
        Skills: {
            Speaking: window.chartData.SpeakingLevels,
            Writing: window.chartData.WritingLevels,
            Listening: window.chartData.ListeningLevels,
            Reading: window.chartData.ReadingLevels,
        }
    };

    const chartData = {
        labels: data.Languages,
        datasets: [
            {
                label: 'Hablar',
                data: data.Skills.Speaking,
                backgroundColor: 'rgba(255, 99, 132, 0.2)',
                borderColor: 'rgba(255, 99, 132, 1)',
                borderWidth: 1
            },
            {
                label: 'Escribir',
                data: data.Skills.Writing,
                backgroundColor: 'rgba(54, 162, 235, 0.2)',
                borderColor: 'rgba(54, 162, 235, 1)',
                borderWidth: 1
            },
            {
                label: 'Escuchar',
                data: data.Skills.Listening,
                backgroundColor: 'rgba(255, 206, 86, 0.2)',
                borderColor: 'rgba(255, 206, 86, 1)',
                borderWidth: 1
            },
            {
                label: 'Leer',
                data: data.Skills.Reading,
                backgroundColor: 'rgba(75, 192, 192, 0.2)',
                borderColor: 'rgba(75, 192, 192, 1)',
                borderWidth: 1
            }
        ]
    };

    new Chart(ctx, {
        type: 'bar',
        data: chartData,
        options: {
            responsive: true,
            maintainAspectRatio: false,
            title: {
                display: true,
                text: "World Wine Production 2018"
            },
            plugins: {
                legend: {
                    position: 'right' 
                },
                tooltip: {
                    callbacks: {
                        label: function (tooltipItem) {
                            return tooltipItem.dataset.label + ': ' + tooltipItem.raw;
                        }
                    }
                }
            },
            scales: {
                x: {
                    stacked: false,
                    grid: {
                        display: false
                    }
                },
                y: {
                    stacked: false,
                    beginAtZero: true,
                    ticks: {
                        callback: function (value) {
                            const labels = {
                                0: 'Principiante (0)',
                                3: 'Noción (3)',
                                6: 'Competencia limitada (6)',
                                9: 'Competencia profesional (9)',
                                12: 'Competencia completada (12)',
                                15: 'Lengua natal o bilingüe (15)'
                            };
                            return labels[value] || '';
                        },
                        stepSize: 1, 
                        min: 0, 
                        max: 15 
                    }
                }
            }
        }
    });
});








    //const myChart = new Chart(ctx, {
    //    type: 'bar', // Puedes usar 'line', 'bar', 'pie', etc.
    //    data: {
    //        labels: window.chartData.Languages, // Los lenguajes
    //        datasets: [{
    //            label: 'Habilidades (0-10)',
    //            data: window.chartData.Levels, // Porcentajes o niveles de habilidad
    //            backgroundColor: [
    //                'rgba(75, 192, 192, 0.2)',
    //                'rgba(153, 102, 255, 0.2)'
    //            ],
    //            borderColor: [ c zùzùzùzùzùzùzùù     7
    //                'rgba(75, 192, 192, 1)',
    //                'rgba(153, 102, 255, 1)'
    //            ],
    //            borderWidth: 1
    //        }]
    //    },
    //    options: {
    //        scales: {
    //            y: {
    //                beginAtZero: true,
    //                max: 10 // Ajusta según el rango de tus datos
    //            }
    //        }
    //    }
    //});

