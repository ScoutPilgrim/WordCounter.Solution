# WordCounterSolution

### Ian Christner

### Description

What it Does:
* Nothing so far, as the user facing aspect of the application is not there.

Specifications:
1. RepeatCounter.cs Specifications:
  * A RepeatCounter object will have these properties:
    1. UserEnteredWord - A string that is the word the user enters to check the occurence of
    2. UserSentence - The sentence the user wishes to compare their word to
    3. SplitList - A List<string> obj that contains all the words of UserSentence
    4. WordCount - An int that simply represents the number of occurrences of UserEnteredWord in UserSentence
  * A RepeatCounter object has to be constructed with two parameters.
    1. A string that is the word the user wants to WordCheck
    2. A string that is the sentence the user wanted to compare the aforementioned word to
  * The user will then want to run the RepeatCounter.GetSplitList() Method. This takes the User's sentence that they input and construct a List Object containing
  all words within the sentence
    * For example, if the user sentence was "This is a test", running RepeatCounter.GetSplitList() would generate List<string>{"This", "is", "a", "test"}.
  * After the split list is generated, it is now safe to call the RepeatCounter.WordCheck() Method. This Iterates through a List, and counts how many times the user's word is found
    * For example, if user's word is "test", and the List<string> is {"This", "is", "a", "test"}, the RepeatCounter object's WordCount property will update to 1, as the word "test" was encountered one time.
    * Expanding on the last example, using the same word but comparing it to the List {"teststst", "testeroo", "testing", "test"}, would yield the same result of 1. We are looking for the exact word, nothing more nothing less. So there is still only 1 instance of "test" here.

### Set Up
1. Download .NET Core 2.2.203 SDK and install it.
2. Download Mono and install it.
3. How to Run:
  1. Clone the Repo: $ git clone https://github.com/ScoutPilgrim/WordCounter.Solution
  2. Change to the cloned directory: $ cd WordCounter.Solution
  3. To run the program, change into the WordCounter Directory and dotnet build/ dotnet run: $ cd WordCounter $ dotnet build $ dotnet run
  4. Navigate to localhost:5000 on your browser to view the program.
#### The MIT License

#### Copyright (c) 2019 Ian Christner

Permission is hereby granted, free of charge,
to any person obtaining a copy of this software and
associated documentation files (the "Software"), to
deal in the Software without restriction, including
without limitation the rights to use, copy, modify,
merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom
the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice
shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR
ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
