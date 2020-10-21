cmake_minimum_required(VERSION 3.9)
project(TennisTest)

set(CMAKE_CXX_STANDARD 11)

add_subdirectory(lib/gtest)

file(GLOB PROD_SRC "src/*.c")
file(GLOB TEST_SRC "test/*.cc")

add_executable(TennisTestExe ${TEST_SRC} ${PROD_SRC} )

target_link_libraries(TennisTestExe gtest gtest_main)

include_directories(lib/gtest/googletest/include)
include_directories(lib/gtest/googlemock/include)



