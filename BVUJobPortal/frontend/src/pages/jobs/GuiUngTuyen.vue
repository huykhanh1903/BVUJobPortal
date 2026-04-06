<template>
  <div class="flex items-center justify-center min-h-screen bg-gradient-to-br from-blue-50 to-blue-100">
    <div class="bg-white shadow-xl rounded-2xl p-8 w-full max-w-xl">

      <h1 class="text-2xl font-bold text-center text-blue-600 mb-6">
        Ứng tuyển công việc
      </h1>

      <!-- Nếu đã ứng tuyển -->
      <div
        v-if="alreadyApplied"
        class="p-4 mb-4 bg-yellow-100 text-yellow-700 rounded text-center font-semibold shadow"
      >
        ⚠️ Bạn đã ứng tuyển công việc này rồi.  
        <br>Không thể gửi lại đơn!
      </div>

      <!-- Thành công -->
      <div
        v-else-if="success"
        class="p-4 mb-4 bg-green-100 text-green-700 rounded text-center font-semibold shadow"
      >
        ✅ Bạn đã ứng tuyển thành công!
      </div>

      <!-- Form -->
      <form
        v-else
        @submit.prevent="applyJob"
        class="space-y-6"
      >
        <!-- Thư giới thiệu -->
        <div>
          <label class="block text-gray-700 mb-2 font-medium">Thư giới thiệu</label>
          <textarea
            v-model="thuGioiThieu"
            placeholder="Hãy giới thiệu ngắn gọn về bạn..."
            class="w-full px-4 py-3 border rounded-xl focus:ring-2 focus:ring-blue-500 focus:outline-none"
            rows="6"
          ></textarea>
        </div>

        <!-- Upload PDF -->
        <div>
          <label class="block text-gray-700 mb-2 font-medium">Đính kèm CV PDF (không bắt buộc)</label>

          <input
            type="file"
            accept="application/pdf"
            @change="onFileChange"
            class="w-full border px-4 py-2 rounded-xl bg-gray-50 cursor-pointer"
          />

          <!-- Preview file -->
          <p v-if="cvFile" class="text-sm text-green-600 mt-2 flex items-center gap-2">
            📎 <span class="font-medium">{{ cvFile.name }}</span>
          </p>

          <p class="text-xs text-gray-500 mt-1">
            Nếu không chọn file PDF, hệ thống sẽ tự gửi CV mặc định của bạn.
          </p>
        </div>

        <button
          type="submit"
          :disabled="loading"
          class="w-full bg-blue-600 text-white py-3 rounded-xl font-semibold
                 hover:bg-blue-700 transition shadow-md flex items-center justify-center
                 disabled:opacity-50 disabled:cursor-not-allowed"
        >
          <span v-if="loading" class="flex items-center gap-2">
            <svg class="animate-spin h-5 w-5 text-white" xmlns="http://www.w3.org/2000/svg" fill="none"
                 viewBox="0 0 24 24">
              <circle class="opacity-25" cx="12" cy="12" r="10"
                      stroke="currentColor" stroke-width="4"></circle>
              <path class="opacity-75" fill="currentColor"
                    d="M4 12a8 8 0 018-8v8H4z"></path>
            </svg>
            Đang gửi...
          </span>

          <span v-else>
            Gửi ứng tuyển
          </span>
        </button>

      </form>

    </div>
  </div>
</template>



<script setup>
import { ref, onMounted } from "vue";
import { useRoute } from "vue-router";
import api from "@/api/axios";

const route = useRoute();

const thuGioiThieu = ref("");
const cvFile = ref(null);
const success = ref(false);
const loading = ref(false);
const alreadyApplied = ref(false);

const onFileChange = (e) => {
  cvFile.value = e.target.files[0];
};

const checkAlreadyApplied = async () => {
  const jobId = parseInt(route.params.id);

  const res = await api.get(`/UngTuyen/kiem-tra?congViecId=${jobId}`);
  alreadyApplied.value = res.data.daUngTuyen === true;
};

const applyJob = async () => {
  try {
    loading.value = true;

    const formData = new FormData();
    formData.append("CongViecId", parseInt(route.params.id));
    formData.append("ThuGioiThieu", thuGioiThieu.value);
    formData.append("CvId", 0);

    if (cvFile.value && cvFile.value.size > 0) {
      formData.append("CvFile", cvFile.value);
    }

    const res = await api.post("/UngTuyen/nop-don", formData, {
      headers: { "Content-Type": "multipart/form-data" }
    });

    if (res.data.success === false) {
      alreadyApplied.value = true;
      alert(res.data.message);
      return;
    }

    success.value = true;

  } catch (err) {
    console.error(err);
    alert("Ứng tuyển thất bại, vui lòng thử lại!");
  } finally {
    loading.value = false;
  }
};

// load data ban đầu
onMounted(checkAlreadyApplied);
</script>
