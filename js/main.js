const scrBox = document.querySelectorAll('.scrBox');
const lis = document.querySelectorAll('ul li');

let posArr = [];
const base = -200;
const btn = document.querySelector('.ScrollBtn');

for (let el of scrBox) {
	posArr.push(el.offsetTop);
}

window.addEventListener('scroll', () => {
	let scroll = window.scrollY || window.pageYOffset;
	console.log(scroll);
	scrBox.forEach((el, index) => {
		if (scroll >= posArr[index] + base) {
			for (let el of lis) el.classList.remove('on');
			lis[index].classList.add('on');
		}
	});

	// if (scroll < 300) {
	// 	new Anim(lis, {
	// 		prop: 'opacity',
	// 		value: 0,
	// 		duration: 300,
	// 	});
	// }
});

lis.forEach((el, index) => {
	el.addEventListener('click', () => {
		new Anim(window, {
			prop: 'scroll',
			value: posArr[index],
			duration: 500,
		});
		for (let el of lis) el.classList.remove('on');
		el.classList.add('on');
	});
});
