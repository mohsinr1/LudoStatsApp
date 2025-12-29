window.renderWinChart = (labels, data) => {
    const ctx = document.getElementById('winsChart').getContext('2d');

    if (window.winChart) {
        window.winChart.destroy();
    }

    window.winChart = new Chart(ctx, {
        type: 'bar',
        data: {
            labels: labels,
            datasets: [{
                label: 'Wins',
                data: data,
                backgroundColor: '#4caf50'
            }]
        },
        options: {
            responsive: true,
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });
};
window.getSelectedPlayers = (selectId, dotNetHelper) => {
    const select = document.getElementById(selectId);
    const selected = Array.from(select.selectedOptions).map(opt => opt.value);
    dotNetHelper.invokeMethodAsync('SetSelectedPlayers', selected);
};
