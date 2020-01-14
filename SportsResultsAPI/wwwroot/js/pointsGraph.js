// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


Highcharts.chart('points', {
    chart: {
        type: 'line'
    },
    title: {
        text: 'Points Scored Per Game'
    },
    subtitle: {
        text: 'Results'
    },
    xAxis: {
        categories: [


        ],
        crosshair: true
    },
    yAxis: {
        min: 0,
        title: {
            text: 'Points Scored'
        }
    },
    tooltip: {
        headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
        pointFormat: '<tr><td style="color:{series.color};padding:0">{series.name}: </td>' +
            '<td style="padding:0"><b>{point.y:.1f} Pts</b></td></tr>',
        footerFormat: '</table>',
        shared: true,
        useHTML: true
    },
    plotOptions: {
        column: {
            pointPadding: 1,
            borderWidth: 0
        }
    },


    series: [{
        name: 'Home',
        color: '#011b51',
        data: [
            ,]

    }, {
        name: 'Away',
        color: '#d51b1b',
        data: [



            ,]

    }]

});
