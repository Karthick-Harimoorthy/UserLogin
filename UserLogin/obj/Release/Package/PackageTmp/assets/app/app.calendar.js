/* ====== Index ======

1. CALENDAR JS

====== End ======*/

document.addEventListener('DOMContentLoaded', function () {
  var calendarEl = document.getElementById('calendar');
  var year = new Date().getFullYear()
  var month = new Date().getMonth() + 1
  var month_1 = new Date().getMonth() + 2

  function n(n) {
    return n > 9 ? "" + n : "0" + n;
  }
  var month = n(month)
  var month_1 = n(month_1)

  var calendar = new FullCalendar.Calendar(calendarEl, {
    plugins: ['dayGrid'],
    defaultView: 'dayGridMonth',
    height: 500,

    eventRender: function (info) {
      var ntoday = moment().format('YYYYMMDD');
      var eventStart = moment(info.event.start).format('YYYYMMDD');
      info.el.setAttribute("title", info.event.extendedProps.description);
      info.el.setAttribute("data-toggle", "tooltip");
      if (eventStart < ntoday) {
        info.el.classList.add("fc-past-event");
      } else if (eventStart == ntoday) {
        info.el.classList.add("fc-current-event");
      } else {
        info.el.classList.add("fc-future-event");
      }
    },

    eventSources: [
      {
        events: [
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month + '-11T06:00:00',
            end: year + '-' + month + '-11T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month + '-12T06:00:00',
            end: year + '-' + month + '-12T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month + '-13T06:00:00',
            end: year + '-' + month + '-13T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month + '-14T06:00:00',
            end: year + '-' + month + '-14T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month + '-17T06:00:00',
            end: year + '-' + month + '-17T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month + '-18T06:00:00',
            end: year + '-' + month + '-18T14:30:00'
          },
          {
            title: 'to 4:30pm',
            description: 'Work 6:00am to 4:30pm',
            start: year + '-' + month + '-19T06:00:00',
            end: year + '-' + month + '-19T16:30:00'
          },
          {
            title: 'to 3:30pm',
            description: 'Work 6:00am to 3:30pm',
            start: year + '-' + month + '-20T06:00:00',
            end: year + '-' + month + '-20T14:30:00'
          },
          {
            title: 'to 3:30pm',
            description: 'Work 6:00am to 3:30pm',
            start: year + '-' + month + '-21T06:00:00',
            end: year + '-' + month + '-21T14:30:00'
          },
          {
            title: 'to 10:00am',
            description: 'Work 6:00am to 10:00am',
            start: year + '-' + month + '-22T06:00:00',
            end: year + '-' + month + '-22T10:00:00'
          },
          {
            title: 'to 3:30pm',
            description: 'Work 6:00am to 3:30pm',
            start: year + '-' + month + '-24T06:00:00',
            end: year + '-' + month + '-24T14:30:00'
          },
          {
            title: 'to 3:30pm',
            description: 'Work 6:00am to 3:30pm',
            start: year + '-' + month + '-25T06:00:00',
            end: year + '-' + month + '-25T14:30:00'
          },
          {
            title: 'to 4:30pm',
            description: 'Work 6:00am to 4:30pm',
            start: year + '-' + month + '-26T06:00:00',
            end: year + '-' + month + '-26T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month_1 + '-02T06:00:00',
            end: year + '-' + month_1 + '-02T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month_1 + '-03T06:00:00',
            end: year + '-' + month_1 + '-03T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month_1 + '-04T06:00:00',
            end: year + '-' + month_1 + '-04T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month_1 + '-05T06:00:00',
            end: year + '-' + month_1 + '-05T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month_1 + '-06T06:00:00',
            end: year + '-' + month_1 + '-06T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month_1 + '-09T06:00:00',
            end: year + '-' + month_1 + '-09T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month_1 + '-10T06:00:00',
            end: year + '-' + month_1 + '-10T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month_1 + '-11T06:00:00',
            end: year + '-' + month_1 + '-11T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month_1 + '-12T06:00:00',
            end: year + '-' + month_1 + '-12T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month_1 + '-13T06:00:00',
            end: year + '-' + month_1 + '-13T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month_1 + '-16T06:00:00',
            end: year + '-' + month_1 + '-16T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month_1 + '-17T06:00:00',
            end: year + '-' + month_1 + '-17T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month_1 + '-18T06:00:00',
            end: year + '-' + month_1 + '-18T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month_1 + '-19T06:00:00',
            end: year + '-' + month_1 + '-19T14:30:00'
          },
          {
            title: 'to 2:30pm',
            description: 'Work 6:00am to 2:30pm',
            start: year + '-' + month_1 + '-20T06:00:00',
            end: year + '-' + month_1 + '-20T14:30:00'
          }
        ],
        color: '#3788d8'
      },
      {
        events: [
          {
            title: 'Planned Vacation',
            description: 'Planned Vacation',
            start: year + '-' + month + '-27'
          },
          {
            title: 'Planned Vacation',
            description: 'Planned Vacation',
            start: year + '-' + month + '-28'
          }
        ],
        color: '#f7c432'

      },
      {
        events: [
          {
            title: 'to 4:30pm (Chg)',
            description: 'Work 6:00am to 4:30pm',
            start: year + '-' + month + '-10T06:00:00',
            end: year + '-' + month + '-10T14:30:00'
          },
          {
            title: 'to 10:00am (Chg)',
            description: 'Work 6:00am to 10:00am',
            start: year + '-' + month + '-15T06:00:00',
            end: year + '-' + month + '-15T10:00:00'
          },
        ],
        color: '#008455'
      }
    ]
  });

  calendar.render();

});