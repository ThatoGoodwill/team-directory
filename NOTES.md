
## Assignment 1.1

## Question 1 

A - The kinds of changes that deserve their own atomic commit for me would be the main method or program or entry point, 
adding the team data file, connecting the program to the team data, adding the search. So would put each meaningful 
change into its own commit. I'd also want to be able to revert back with ease to the last working project.

B - Commits that should be bundled together should be something that doesn't really have a meaningful effect, such as a
typo or a whitespace or even a console.log that I added and then removed in the same sitting. The extra commits don't 
really have useful information. These small changes will give my co-workers or people working on my project extra 
unneccessary work that takes time. It also makes the history more cluttered. 

C - .env might have secrets or configurations that should be kept a secret. *.log are files are made by the program
and don't have any useful parts of code.

## Question 2 
Merge: preserves the branching history and shows where histories joined.
Rebase: sacrifices or re-writes the original branch history to produce a cleaner, linear history.
I would choose merge for the intentional conflict because I want the conflict resolution to be visible in the history 
and I want to preserve evidence that the branches developed separately before being combined.

## Question 3 
git push  -> sends local commits/changes to GitHub
git fetch -> downloads information/commits from GitHub without integrating them
git pull  -> downloads changes from GitHub and integrates them locally
A successful git push does not mean that the code works correctly, that the project requirements have been met, or 
that tests pass. It only confirms that the remote repository accepted the pushed Git updates.

## Question 4 
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



## Part 3
Task 4: The feature/add-search branch was merged into main using a fast-forward merge. I could tell because Git moved 
main directly to the latest feature commit without creating a separate merge commit. (This one I didn't know, I had AI
tell me this but don't understand it still)

Task 9: I rebased feature/add-count onto the latest main, which replayed the feature commit on top of the updated main branch and gave it a new commit hash. I then merged the branch using a fast-forward merge. Unlike the earlier conflict merge, this produced a straight, linear history instead of another branch diamond.

## Part 4 
Testing rejected push recovery.

## Assignment 1.2

## Question 1 - Why fork, not branch, this time?

A fork is a good choice as I will be contributing to my partner's repository, where I do not have write access. A fork creates my own copy of my partner's repository on GithHub which allows me to make changes and push to my own fork. 

If I try to clone my partner's repository and creat a branch, I would still be tryin to push that branch to a repository that I do not own. Github would reject the push unless my partner has granted me write access as a collaborator. With a fork, I can work safely in my own copy and then open a pull request to my partner's original repository.

## Question 2 - PR description : bad vs good

Example of bad PR description can be " Added search"

Example of good PR description can be:
 "What:  Added a way to search team members by role."
 "Why :  This makes it easy to find members who have a specific role without having to look through the whole directory"
 "How to verify:  Run the application, enter a role such as "Developer" in the search field, and confirm that only team members with that role are displayed.

 The second description is easier to review because it clearly explains what changed and why that changed was made and also how the reviewer can test the feature.

 ##  Question 3 — Triaging review comments

A blocking comment identifies a problem that should be fixed before the Pull Request is merged. For example, a search feature that crashes when the user enters an empty value would be a blocking issue.

A nit/suggestion is optional feedback that could improve the code but is not serious enough to prevent the Pull Request from being merged. For example, suggesting a clearer variable name would normally be a nit.

A question is when the reviewer wants clarification about a decision or part of the code. For example, the reviewer might ask why a particular approach was chosen.

If the reviewer does not label the comment, I will decide based on whether it affects the correctness or required behaviour of the feature. If it can cause a bug or means the requirement is not properly met, I will treat it as blocking. If it is mainly about style or an optional improvement, I will treat it as a nit/suggestion. If the reviewer is asking for an explanation, I will treat it as a question.

## Question 4 — When fetch beats pull

I would deliberately use git fetch after my partner has merged a contribution into my repository and before updating my original local repository. git fetch allows me to download information about the remote changes without immediately changing my local main branch.

I could then run git log --oneline main origin/main to compare my local main with origin/main and inspect the changes. After confirming what my partner's contribution looks like, I would run git pull to bring those changes into my local main.

## No-Partner Fallback

I used the no-partner fallback because I was unable to pair with another student for the repository collaboration tasks. I used a second personal GitHub account, thatogoodwill75-collab, to act as the partner and completed the required fork, Pull Request, review, feedback, merge, cleanup, and fetch/pull workflow.