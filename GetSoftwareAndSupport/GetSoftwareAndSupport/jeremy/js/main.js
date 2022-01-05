/*
*  Copyright (c) 2015 The WebRTC project authors. All Rights Reserved.
*
*  Use of this source code is governed by a BSD-style license
*  that can be found in the LICENSE file in the root of the source
*  tree.
*/

// This code is adapted from
// https://rawgit.com/Miguelao/demos/master/mediarecorder.html

'use strict';

/* globals MediaRecorder */

let mediaRecorder;
let recordedBlobs;

const errorMsgElement = document.querySelector('span#errorMsg');
const recordedVideo = document.querySelector('video#recorded');
const recordButton = document.querySelector('button#record');
recordButton.addEventListener('click', () => {
    if (recordButton.textContent === 'Start Recording') {
        startRecording();
    } else {
        stopRecording();
        recordButton.textContent = 'Start Recording';
        playButton.disabled = false;
        downloadButton.disabled = false;
    }
});

const playButton = document.querySelector('button#play');
playButton.addEventListener('click', () => {
    const superBuffer = new Blob(recordedBlobs, { type: 'video/mp4' });
    recordedVideo.src = null;
    recordedVideo.srcObject = null;
    recordedVideo.src = window.URL.createObjectURL(superBuffer);
    recordedVideo.controls = true;
    recordedVideo.play();
     
});
function PostBlob(blob) {
    // FormData
    var formData = new FormData();
    //formData.append('video-blob', blob);
    formData.append('video-blob', blob, blob.name);
    
    //var data = new FormData($('form')[0]);
    // progress-bar
    //var hr = document.createElement('hr');
    //container.appendChild(hr);
    //var strong = document.createElement('strong');
    //strong.id = 'percentage';
    //strong.innerHTML = 'Video upload progress: ';
    //container.appendChild(strong);
    //var progress = document.createElement('progress');
    //container.appendChild(progress);
    //var textboxvalue = $('input[name="textbox1"]').val();
    var textboxvalue = $("input[name*='textbox1']").val();
    var textboxurlvalue = $("input[name*='textbox_Url']").val();

    const Http = new XMLHttpRequest();
    const url = textboxurlvalue + "?name=" + textboxvalue;
    Http.open("Post", url);     
   
    //Http.onreadystatechange = function () {//Call a function when the state changes.
    //    if (Http.readyState == 4 && Http.status == 200) {
      
    //    }
    //}
    Http.send(formData)
    //window.location.assign("/MyVideos");
    //if (Http.response) {
    //    $("#Content").html(formData.responseText);
    //        } else {
    //            // DoSomethingElse()
    //    $("#Content").html(formData.responseText); 
    //        }

    // POST the Blob  
    //var jsonData = JSON.stringify(obj);

    //// Initialize the object, before adding data to it.
    ////  { } is declarative shorthand for new Object()
    //var obj = {};
    //obj.message1 = '';
    //obj.message2 = '';
    
    //$.ajax({
    //    type: "POST", 
    //    //url: "Video_Uploader.ashx",
    //   // url: "Session_Test.aspx",
    //   // url: '<%= ResolveUrl("~/Session_Test.aspx)%>' + "?Name=" + $('#txt_email').val(),
    //  //  url: "Session_Test.aspx" + "?name=" + textboxvalue,
    // //  url: "Video_Uploader.ashx" + "?name=" + textboxvalue,
    //   //  url: textboxurlvalue + "?name=" + textboxvalue,
    //   //url: "/Session_Test.aspx" + "?name=" + textboxvalue,

    //   // url: "/Session_Test.aspx",
    //   // url: '<%= Page.ResolveUrl(' + textboxurlvalue + ')%>' + textboxvalue ,
    //    //~/
    //   // url: "~/Video_Uploader.ashx" + "?name=" + textboxvalue,
    //    //contentType: "application/json; charset=utf-8",
    //    //dataType: "json",
    //    //contentType: "application/json; charset=utf-8",
    //    //dataType: "json",
    //    //success: function (data) {
    //    //    console.log(data);
    //    //    alert("Success :" + data);
    //    //},
    //    //error: function (errorText) {
    //    //    alert("Wwoops something went wrong !");
    //    //}
     
    //   // headers: { "cache-control": "no-cache" };
    //   // async: false,
    //    data: formData,
    //    cache: false,
    //   // contentType: "application/json;charset=utf-8",
    //  enctype: 'multipart/form-data',
    //  contentType: false,
    //  processData: false,  // Important!
    //    success: function (response) {
    //        if (response.success) { 
    //            $("#Content").html(response.responseText); 
    //        } else {
    //            // DoSomethingElse()
    //            $("#Content").html(response.responseText); 
    //        }
    //    },
    //    error: function (response) {
    //        $("#Content").html(response.responseText); 
    //    }
        
    //})
}

    
 

function OnSuccess(response) {
    alert(response.d);
}
const downloadButton = document.querySelector('button#download');
downloadButton.addEventListener('click', () => {
    const blob = new Blob(recordedBlobs, { type: 'video/mp4' });
    const url = window.URL.createObjectURL(blob);
    const a = document.createElement('a');
    a.style.display = 'none';
    a.href = url;
    a.download = 'test.mp4';
    document.body.appendChild(a);
    
   // PostBlob(blob);
    //a.click();
    //PostBlob(blob);
    //setTimeout(() => {
    //    document.body.removeChild(a);
    //    window.URL.revokeObjectURL(url);
    //}, 100);
      //window.location.replace("/MyVideos");
    PostBlob(blob);
});

function handleDataAvailable(event) {
    console.log('handleDataAvailable', event);
    if (event.data && event.data.size > 0) {
        recordedBlobs.push(event.data);
    }
}
//function OnSuccess(response, userContext, methodName) {
//    alert(response);
//}
function startRecording() {
    recordedBlobs = [];
    let options = { mimeType: 'video/webm;codecs=vp9,opus' };
    if (!MediaRecorder.isTypeSupported(options.mimeType)) {
        console.error(`${options.mimeType} is not supported`);
        options = { mimeType: 'video/webm;codecs=vp8,opus' };
        if (!MediaRecorder.isTypeSupported(options.mimeType)) {
            console.error(`${options.mimeType} is not supported`);
            options = { mimeType: 'video/webm' };
            if (!MediaRecorder.isTypeSupported(options.mimeType)) {
                console.error(`${options.mimeType} is not supported`);
                options = { mimeType: '' };
            }
        }
    }

    try {
        mediaRecorder = new MediaRecorder(window.stream, options);
    } catch (e) {
        console.error('Exception while creating MediaRecorder:', e);
        errorMsgElement.innerHTML = `Exception while creating MediaRecorder: ${JSON.stringify(e)}`;
        return;
    }

    console.log('Created MediaRecorder', mediaRecorder, 'with options', options);
    recordButton.textContent = 'Stop Recording';
    playButton.disabled = true;
    downloadButton.disabled = true;
    mediaRecorder.onstop = (event) => {
        console.log('Recorder stopped: ', event);
        console.log('Recorded Blobs: ', recordedBlobs);
    };
    mediaRecorder.ondataavailable = handleDataAvailable;
    mediaRecorder.start();
    console.log('MediaRecorder started', mediaRecorder);
}

function stopRecording() {
    mediaRecorder.stop();
}

function handleError(error) {
    console.error('Error: ', error);
    //var s = error.name;
    
    //if (s.match(/^notallowederror.*$/)) {
    //    alert('Please select a Camera or Microphone');
    //}
    //alert(error.name);
    if (error.name === 'NotAllowedError') {
        alert('Please enable a camera and a microphone to use this app. Recording is currently disabled. You can enable this to the right of your URL. After you enable the Camaera , please refresh the page.');
    }
    // else
    //{
    //    alert(error.name);
    //}
    
}

function handleSuccess(stream) {
    recordButton.disabled = false;
    console.log('getUserMedia() got stream:', stream);
    window.stream = stream;

    const gumVideo = document.querySelector('video#gum');
    gumVideo.srcObject = stream;
}

//async function init(constraints) {
//    try {
//        const stream = await navigator.mediaDevices.getUserMedia(constraints);
//        handleSuccess(stream);
//    } catch (e) {
//        console.error('navigator.getUserMedia error:', e);
//        errorMsgElement.innerHTML = `navigator.getUserMedia error:${e.toString()}`;
//    }
//}

var videoElement = document.querySelector('video');
var audioSelect = document.querySelector('select#audioSource');
var videoSelect = document.querySelector('select#videoSource');

audioSelect.onchange = getStream;
videoSelect.onchange = getStream;

getStream().then(getDevices).then(gotDevices);

function getDevices() {
    // AFAICT in Safari this only gets default devices until gUM is called :/
    return navigator.mediaDevices.enumerateDevices();
}

function gotDevices(deviceInfos) {
    window.deviceInfos = deviceInfos; // make available to console
    console.log('Available input and output devices:', deviceInfos);
    for (const deviceInfo of deviceInfos) {
        const option = document.createElement('option');
        option.value = deviceInfo.deviceId;
        if (deviceInfo.kind === 'audioinput') {
            option.text = deviceInfo.label || `Microphone ${audioSelect.length + 1}`;
            audioSelect.appendChild(option);
        } else if (deviceInfo.kind === 'videoinput') {
            option.text = deviceInfo.label || `Camera ${videoSelect.length + 1}`;
            videoSelect.appendChild(option);
        }
    }
}
function test_compatibility() {
if ('mediaDevices' in navigator && 'getUserMedia' in navigator.mediaDevices) {
    //alert("Let's get this party started")
    }
else {
    alert("A device is not enabled or your browser doesn not support Recording. Please enable or try another browser.")
}
//else {
//    alert('A device is not enabled or your browser doesn not support Recording. Please enable or try another browser. '
//}
}
function getStream() {
    test_compatibility();
    if (window.stream) {
        window.stream.getTracks().forEach(track => {
            track.stop();
        });
    }
    const audioSource = audioSelect.value;
    const videoSource = videoSelect.value;
    const constraints = {
        audio: { deviceId: audioSource ? { exact: audioSource } : undefined },
        video: { deviceId: videoSource ? { exact: videoSource } : undefined }
    };
    return navigator.mediaDevices.getUserMedia(constraints).
        then(gotStream).catch(handleError);
}


function gotStream(stream) {
    handleSuccess(stream);

}
//async function init(constraints) {
//    try {
//        const stream = await navigator.mediaDevices.getUserMedia(constraints);
//        handleSuccess(stream);
//    } catch (e) {
//        console.error('navigator.getUserMedia error:', e);
//        errorMsgElement.innerHTML = `navigator.getUserMedia error:${e.toString()}`;
//    }
//}

document.querySelector('button#start').addEventListener('click', async () => {
    const hasEchoCancellation = document.querySelector('#echoCancellation').checked;
    const constraints = {
        audio: {
            //echoCancellation: { exact: hasEchoCancellation }
        },
        video: {
            //width: 1280, height: 720
            //video: true,
        }
    };
    console.log('Using media constraints:', constraints);
    await init(constraints);
});