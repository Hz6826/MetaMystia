using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace GameData.RunTime.Common.AchievementSystem
{
	// Token: 0x02000231 RID: 561
	public class AchievementNotifyResult : Object
	{
		// Token: 0x0600463F RID: 17983 RVA: 0x00191378 File Offset: 0x0018F578
		// Note: this type is marked as 'beforefieldinit'.
		static AchievementNotifyResult()
		{
			Il2CppClassPointerStore<AchievementNotifyResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.RunTime.Common.AchievementSystem", "AchievementNotifyResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementNotifyResult>.NativeClassPtr);
			AchievementNotifyResult.NativeFieldInfoPtr_IntKeyValuePair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementNotifyResult>.NativeClassPtr, "IntKeyValuePair");
			AchievementNotifyResult.NativeFieldInfoPtr_IntValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementNotifyResult>.NativeClassPtr, "IntValue");
			AchievementNotifyResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementNotifyResult>.NativeClassPtr, 100677206);
		}

		// Token: 0x06004640 RID: 17984 RVA: 0x001913E4 File Offset: 0x0018F5E4
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AchievementNotifyResult() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementNotifyResult>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementNotifyResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x00024990 File Offset: 0x00022B90
		public AchievementNotifyResult(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x06004642 RID: 17986 RVA: 0x00191420 File Offset: 0x0018F620
		// (set) Token: 0x06004643 RID: 17987 RVA: 0x00024999 File Offset: 0x00022B99
		public KeyValuePair<int, int> IntKeyValuePair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementNotifyResult.NativeFieldInfoPtr_IntKeyValuePair);
				return new KeyValuePair<int, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<int, int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementNotifyResult.NativeFieldInfoPtr_IntKeyValuePair), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<int, int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x06004644 RID: 17988 RVA: 0x00191450 File Offset: 0x0018F650
		// (set) Token: 0x06004645 RID: 17989 RVA: 0x000249C7 File Offset: 0x00022BC7
		public unsafe int IntValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementNotifyResult.NativeFieldInfoPtr_IntValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementNotifyResult.NativeFieldInfoPtr_IntValue)) = value;
			}
		}

		// Token: 0x04002FF4 RID: 12276
		private static readonly IntPtr NativeFieldInfoPtr_IntKeyValuePair;

		// Token: 0x04002FF5 RID: 12277
		private static readonly IntPtr NativeFieldInfoPtr_IntValue;

		// Token: 0x04002FF6 RID: 12278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
