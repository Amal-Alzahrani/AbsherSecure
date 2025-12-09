// محاكاة بسيطة لبصمة الوجه و الاصبع
document.addEventListener('DOMContentLoaded', function () {
    const btnFace = document.getElementById('btnFace');
    const btnFinger = document.getElementById('btnFinger');
    const faceIndicator = document.getElementById('faceIndicator');
    const fingerIndicator = document.getElementById('fingerIndicator');
    const btnFinish = document.getElementById('btnFinish');

    function setSuccess(el) {
        el.classList.add('success');
    }

    function checkFinish() {
        if (faceIndicator.classList.contains('success') && fingerIndicator.classList.contains('success')) {
            btnFinish.disabled = false;
            btnFinish.addEventListener('click', function () {
                // بعد الضغط ننقل لصفحة النجاح
                window.location.href = '/Issue/Success';
            });
        }
    }

    if (btnFace) {
        btnFace.addEventListener('click', function () {
            // محاكاة انتظار والتحقق
            btnFace.disabled = true;
            btnFace.textContent = 'جاري التحقق...';
            setTimeout(function () {
                setSuccess(faceIndicator);
                btnFace.textContent = 'تم';
                checkFinish();
            }, 1200);
        });
    }

    if (btnFinger) {
        btnFinger.addEventListener('click', function () {
            btnFinger.disabled = true;
            btnFinger.textContent = 'جاري التحقق...';
            setTimeout(function () {
                setSuccess(fingerIndicator);
                btnFinger.textContent = 'تم';
                checkFinish();
            }, 1200);
        });
    }
    function enableEndRequest() {
        const btn = document.getElementById("endRequestBtn");
        btn.disabled = false;
        btn.style.opacity = "1";
        btn.style.cursor = "pointer";
    }
    document.getElementById("btnFinger").innerText = "تم التحقق";
    enableEndRequest();
    document.getElementById("btnFace").innerText = "تم التحقق";
    enableEndRequest();
});