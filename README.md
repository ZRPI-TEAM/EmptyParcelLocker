# Submodules instruction

## Clone repo with submodules

`git clone -recurse-submodules [URL to Git repo]`

## Update submodules

`git submodule update --remote`

> fetches new commits **in** the submodules, and updates the working tree to the commit described by the branch

## After entering a submodule folder - make sure you are on correct branch.

`git switch <branch_name>`

## Add a new submodule and track its branch (if hasn't been added yet)

`git submodule add -b main [URL to Git repo]`

`git submodule init`

## Execute a commend on every submodule

`git submodule foreach 'git reset --hard'`
