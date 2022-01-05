/*
Copyright 2017 Google Inc.
Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
    http://www.apache.org/licenses/LICENSE-2.0
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

'use strict';
 
    if (navigator.getUserMedia) {
        navigator.getUserMedia(
            // constraints
            {
                video: true,
                audio: true
            },
            // successCallback
            function (localMediaStream) {
                var video = document.querySelector('video');
                video.src = window.URL.createObjectURL(localMediaStream);
                // do whatever you want with the video
                video.play();
            },
            // errorCallback
            function (err) {
                console.log("The following error occured: " + err);
            });
        } else {
        alert("getUserMedia not supported by your web browser or Operating system version");
        }
 
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
function UpdateTime(time) {
    document.getElementById("<%=lblTime.ClientID %>").innerHTML = time;
}
function getStream() {
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
    window.stream = stream; // make stream available to console
    audioSelect.selectedIndex = [...audioSelect.options].
        findIndex(option => option.text === stream.getAudioTracks()[0].label);
    videoSelect.selectedIndex = [...videoSelect.options].
        findIndex(option => option.text === stream.getVideoTracks()[0].label);
    videoElement.srcObject = stream;
     
}

function handleError(error) {
    console.error('Error: ', error);
}


 
    let preview = document.getElementById("preview");
    let recording = document.getElementById("recording");
    let startButton = document.getElementById("startButton");
    let stopButton = document.getElementById("stopButton");
    let downloadButton = document.getElementById("downloadButton");
    let logElement = document.getElementById("log");

    let recordingTimeMS = 5000;

          function log(msg) {
        logElement.innerHTML += msg + "\n";
          }



          function wait(delayInMS) {
              return new Promise(resolve => setTimeout(resolve, delayInMS));
          }


          function startRecording(stream, lengthInMS) {
        let recorder = new MediaRecorder(stream);
              let data = [];

              recorder.ondataavailable = event => data.push(event.data);
              recorder.start();
              log(recorder.state + " for " + (lengthInMS / 1000) + " seconds...");

              let stopped = new Promise((resolve, reject) => {
        recorder.onstop = resolve;
                  recorder.onerror = event => reject(event.name);
              });

              let recorded = wait(lengthInMS).then(
                  () => recorder.state == "recording" && recorder.stop()
              );

              return Promise.all([
                  stopped,
                  recorded
              ])
                  .then(() => data);
          }


          function stop(stream) {
        stream.getTracks().forEach(track => track.stop());
          }

var button = document.getElementById("stopButton");
button.addEventListener("click", function (event) {
    video.srcObject = stream;
});

var button = document.getElementById("startButton");
button.addEventListener("click", function (event) {
    alert(event.target);






});

          startButton.addEventListener("click", function () {
        navigator.mediaDevices.getUserMedia({
            video: true,
            audio: true
        }).then(stream => {
            preview.srcObject = stream;
            downloadButton.href = stream;
            preview.captureStream = preview.captureStream || preview.mozCaptureStream;
            return new Promise(resolve => preview.onplaying = resolve);
        }).then(() => startRecording(preview.captureStream(), recordingTimeMS))
            .then(recordedChunks => {
                let recordedBlob = new Blob(recordedChunks, { type: "video/webm" });
                recording.src = URL.createObjectURL(recordedBlob);
                downloadButton.href = recording.src;
                alert(recording.src);
                downloadButton.download = "RecordedVideo.webm";

                log("Successfully recorded " + recordedBlob.size + " bytes of " +
                    recordedBlob.type + " media.");
            })
            .catch(log);
          }, false);




          stopButton.addEventListener("click", function () {
        stop(preview.srcObject);
          }, false);

 
   
 