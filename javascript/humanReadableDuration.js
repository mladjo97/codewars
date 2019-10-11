// Link to kata: https://www.codewars.com/kata/52742f58faf5485cae000b9a

function formatDuration(seconds) {
    if (seconds === 0) { return 'now'; }

    var years   =   Math.floor(seconds / (60 * 60 * 24 * 365));
    var days    =   Math.floor(seconds / (60 * 60 * 24)) % 365;
    var hours   =   Math.floor(seconds / (60 * 60)) % 24;
    var minutes =   Math.floor(seconds / 60) % 60;
    var seconds =   seconds % 60;

    var duration = [years, days, hours, minutes, seconds];
    var units = ['year', 'day', 'hour', 'minute', 'second'];

    var linked = duration.map(function (el, ind) {
        if (el > 1) { return el + ' ' + units[ind] + 's' }
        if (el === 1) { return el + ' ' + units[ind] }
    }).filter(el => el !== undefined);

    if (linked.length > 1) {
        var last = linked.pop();
        return linked.join(', ') + ' and ' + last;
    } else {
        return linked[0];
    }
}