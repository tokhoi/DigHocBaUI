//window.drawPieChart = (containerId, data) => {
//    const container = document.getElementById(containerId);
//    if (!container) return;

//    const pieElement = container.querySelector('.pie-solid');
//    if (!pieElement) return;

//    let gradientParts = [];
//    let currentPercent = 0;

//    data.forEach((item, index) => {
//        const start = currentPercent;
//        const end = currentPercent + item.percent;

//        gradientParts.push(`${item.color} ${start}% ${end}%`);

//        const midPercent = (start + end) / 2;
//        const degrees = midPercent * 3.6;

//        const label = container.querySelector(`.pie-label-auto[data-index="${index}"]`);
//        if (label) {
//            label.style.setProperty('--deg', `${degrees}deg`);
//            label.innerText = `${item.percent}%`;
//        }

//        currentPercent += item.percent;
//    });

//    pieElement.style.background = `conic-gradient(${gradientParts.join(', ')})`;
//};