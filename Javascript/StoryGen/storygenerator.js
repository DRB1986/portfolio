function generateStory() {
  var form = document.getElementById('inputForm');
  var story = document.getElementById('story');
  var inputSection = document.getElementById('inputSection');
  var storySection = document.getElementById('storySection');

  for (var i = 0; i < form.elements.length - 1; i++) {
      var input = form.elements[i].value.trim();
      var storySpan = story.children[i];
      if (input !== "") {
          storySpan.textContent = input;
          storySpan.classList.remove('missing');
      } else {
          storySpan.textContent = '[<missing text>]';
          storySpan.classList.add('missing');
      }
  }

  inputSection.style.display = 'none';
  storySection.style.display = 'block';
}

function returnToInput() {
  var inputSection = document.getElementById('inputSection');
  var storySection = document.getElementById('storySection');

  inputSection.style.display = 'block';
  storySection.style.display = 'none';
}

function resetForm() {
  var form = document.getElementById('inputForm');
  for (var i = 0; i < form.elements.length - 1; i++) {
      form.elements[i].value = '';
  }
  var storySpans = document.querySelectorAll('#story .missing');
  storySpans.forEach(function(span) {
      span.textContent = '[<missing text>]';
  });
}

  