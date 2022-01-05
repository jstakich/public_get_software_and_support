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

 


        let startBtn = document.querySelector('.js-start');
let stopBtn = document.querySelector('.js-stop');
let playBtn = document.querySelector('.js-play');
let pauseBtn = document.querySelector('.js-pause');
 navigator.mediaDevices.getUserMedia({ audio: true })
 .then(stream => {
 const mediaRecorder = new MediaRecorder(stream);
 const audioChunks = [];
startBtn.addEventListener('click', () => {
 audioChunks.length = 0;
 mediaRecorder.start();
 mediaRecorder.addEventListener("dataavailable", event => {
 audioChunks.push(event.data);
 });
 startBtn.setAttribute('disabled', true);
stopBtn.removeAttribute('disabled');
 playBtn.setAttribute('disabled', true);
 pauseBtn.setAttribute('disabled', true);
 });
stopBtn.addEventListener('click', () => {
 mediaRecorder.stop();
 playBtn.removeAttribute('disabled');
 stopBtn.setAttribute('disabled', true);
 });
playBtn.addEventListener('click', () => {
 audioChunks.length = 1;
 const audioBlob = new Blob(audioChunks);
 const audioUrl = URL.createObjectURL(audioBlob);
 const audio = new Audio(audioUrl);
 audio.play();
 startBtn.removeAttribute('disabled');
 stopBtn.setAttribute('disabled', true);
 pauseBtn.removeAttribute('disabled');

 pauseBtn.addEventListener('click', () => {
 audio.pause();
 pauseBtn.setAttribute('disabled', true);
 });
 });
 });