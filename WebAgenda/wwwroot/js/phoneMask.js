function phoneMask(phone) {
    const text = phone.value;
    const isCelPhone = text.substring(2, 3) == 9;
    //const newText = text.replace(/\-/g, '');
    newText = text.replace(/[^\d]+/g, '');
    let adjustedText;
    if (isCelPhone) {
        const DDD = newText.slice(0, 2);
        const text1 = newText.slice(2, 7);
        const text2 = newText.slice(7, 11);
        adjustedText = `(${DDD}) ${text1}-${text2}`
    }
    else {
        const DDD = newText.slice(0, 2);
        const text1 = newText.slice(2, 6);
        const text2 = newText.slice(6, 10);
        adjustedText = `(${DDD}) ${text1}-${text2}`
    }
    phone.value = adjustedText;
}