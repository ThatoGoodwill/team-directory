<<< Question 1 >>>
A - The kinds of changes that deserve their own atomic commit for me would be the main method or program or entry point, 
adding the team data file, connecting the program to the team data, adding the search. So would put each meaningful 
change into its own commit. I'd also want to be able to revert back with ease to the last working project.

B - Commits that should be bundled together should be something that doesn't really have a meaningful effect, such as a
typo or a whitespace or even a console.log that I added and then removed in the same sitting. The extra commits don't 
really have useful information. These small changes will give my co-workers or people working on my project extra 
unneccessary work that takes time. It also makes the history more cluttered. 

C - .env might have secrets or configurations that should be kept a secret. *.log are files are made by the program
and don't have any useful parts of code.

<<< Question 2 >>>
Merge: preserves the branching history and shows where histories joined.
Rebase: sacrifices or re-writes the original branch history to produce a cleaner, linear history.
I would choose merge for the intentional conflict because I want the conflict resolution to be visible in the history 
and I want to preserve evidence that the branches developed separately before being combined.

<<< Question 3 >>>
git push  -> sends local commits/changes to GitHub
git fetch -> downloads information/commits from GitHub without integrating them
git pull  -> downloads changes from GitHub and integrates them locally
A successful git push does not mean that the code works correctly, that the project requirements have been met, or 
that tests pass. It only confirms that the remote repository accepted the pushed Git updates.

<<< Question 4 >>>
A: Fixed stuff -> Its bad because its too vague and doesn't explain what actually changed. A better commit message would 
be something like "Display all team members" because it explains what was added or changed.

B: Update index.js -> Its bad because it's too vague. It tells us which file was updated but doesn't explain what was 
actually changed. A better commit message would be something like "Add team member search to Update index.js"

C: WIP -> Bad because it doesn't explain what work was actually done in the commit.
A better message would be "Add team data loading"

D: Add email format validation so invalid addresses cannot be submitted -> It describes the solution well but its way 
long. A better message would be "Validate email format before submission"

E: asdasd -> Bad because it has no clear meaning and doesn't explain what was changed. A better message would be: Add 
team member sorting"

F: Changed line 47 of notes.md -> Bad because line 47 could change in the future and the message doesn't explain what was 
actually changed. A better message would be "Clarify public members"



=============================================================================================================================



<<< Part 3 >>>
Task 4: The feature/add-search branch was merged into main using a fast-forward merge. I could tell because Git moved 
main directly to the latest feature commit without creating a separate merge commit. (This one I didn't know, I had AI
tell me this but don't understand it still)

Task 9: I rebased feature/add-count onto the latest main, which replayed the feature commit on top of the updated main branch and gave it a new commit hash. I then merged the branch using a fast-forward merge. Unlike the earlier conflict merge, this produced a straight, linear history instead of another branch diamond.

<<< Part 4 >>>
Testing rejected push recovery.