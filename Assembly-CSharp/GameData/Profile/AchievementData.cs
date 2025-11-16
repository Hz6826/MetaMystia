using System;
using GameData.RunTime.Common.AchievementSystem;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Profile
{
	// Token: 0x020002C1 RID: 705
	[Serializable]
	public sealed class AchievementData : ValueType
	{
		// Token: 0x0600581A RID: 22554 RVA: 0x001C7B34 File Offset: 0x001C5D34
		// Note: this type is marked as 'beforefieldinit'.
		static AchievementData()
		{
			Il2CppClassPointerStore<AchievementData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "AchievementData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementData>.NativeClassPtr);
			AchievementData.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "Id");
			AchievementData.NativeFieldInfoPtr_StreamVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "StreamVariable");
			AchievementData.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "Description");
			AchievementData.NativeFieldInfoPtr_IntData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "IntData");
			AchievementData.NativeFieldInfoPtr_IntArrayData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "IntArrayData");
			AchievementData.NativeFieldInfoPtr_StringData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "StringData");
			AchievementData.NativeFieldInfoPtr_StringArrayData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "StringArrayData");
			AchievementData.NativeFieldInfoPtr_AchievementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "AchievementType");
			AchievementData.NativeFieldInfoPtr_NativeProgressMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, "NativeProgressMaxValue");
		}

		// Token: 0x0600581B RID: 22555 RVA: 0x0002F2FE File Offset: 0x0002D4FE
		public AchievementData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600581C RID: 22556 RVA: 0x0002F307 File Offset: 0x0002D507
		public AchievementData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementData>.NativeClassPtr))
		{
		}

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x0600581D RID: 22557 RVA: 0x001C7C18 File Offset: 0x001C5E18
		// (set) Token: 0x0600581E RID: 22558 RVA: 0x0002F319 File Offset: 0x0002D519
		public unsafe string Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x0600581F RID: 22559 RVA: 0x001C7C40 File Offset: 0x001C5E40
		// (set) Token: 0x06005820 RID: 22560 RVA: 0x0002F338 File Offset: 0x0002D538
		public unsafe string StreamVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_StreamVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_StreamVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x06005821 RID: 22561 RVA: 0x001C7C68 File Offset: 0x001C5E68
		// (set) Token: 0x06005822 RID: 22562 RVA: 0x0002F357 File Offset: 0x0002D557
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x06005823 RID: 22563 RVA: 0x001C7C90 File Offset: 0x001C5E90
		// (set) Token: 0x06005824 RID: 22564 RVA: 0x0002F376 File Offset: 0x0002D576
		public unsafe int IntData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_IntData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_IntData)) = value;
			}
		}

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x06005825 RID: 22565 RVA: 0x001C7CB8 File Offset: 0x001C5EB8
		// (set) Token: 0x06005826 RID: 22566 RVA: 0x0002F391 File Offset: 0x0002D591
		public unsafe Il2CppStructArray<int> IntArrayData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_IntArrayData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_IntArrayData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x06005827 RID: 22567 RVA: 0x001C7CE8 File Offset: 0x001C5EE8
		// (set) Token: 0x06005828 RID: 22568 RVA: 0x0002F3B0 File Offset: 0x0002D5B0
		public unsafe string StringData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_StringData);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_StringData), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x06005829 RID: 22569 RVA: 0x001C7D10 File Offset: 0x001C5F10
		// (set) Token: 0x0600582A RID: 22570 RVA: 0x0002F3CF File Offset: 0x0002D5CF
		public unsafe Il2CppStringArray StringArrayData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_StringArrayData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_StringArrayData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x0600582B RID: 22571 RVA: 0x001C7D40 File Offset: 0x001C5F40
		// (set) Token: 0x0600582C RID: 22572 RVA: 0x0002F3EE File Offset: 0x0002D5EE
		public unsafe AchievementType AchievementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_AchievementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_AchievementType)) = value;
			}
		}

		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x0600582D RID: 22573 RVA: 0x001C7D68 File Offset: 0x001C5F68
		// (set) Token: 0x0600582E RID: 22574 RVA: 0x0002F409 File Offset: 0x0002D609
		public unsafe int NativeProgressMaxValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_NativeProgressMaxValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementData.NativeFieldInfoPtr_NativeProgressMaxValue)) = value;
			}
		}

		// Token: 0x04003B11 RID: 15121
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x04003B12 RID: 15122
		private static readonly IntPtr NativeFieldInfoPtr_StreamVariable;

		// Token: 0x04003B13 RID: 15123
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x04003B14 RID: 15124
		private static readonly IntPtr NativeFieldInfoPtr_IntData;

		// Token: 0x04003B15 RID: 15125
		private static readonly IntPtr NativeFieldInfoPtr_IntArrayData;

		// Token: 0x04003B16 RID: 15126
		private static readonly IntPtr NativeFieldInfoPtr_StringData;

		// Token: 0x04003B17 RID: 15127
		private static readonly IntPtr NativeFieldInfoPtr_StringArrayData;

		// Token: 0x04003B18 RID: 15128
		private static readonly IntPtr NativeFieldInfoPtr_AchievementType;

		// Token: 0x04003B19 RID: 15129
		private static readonly IntPtr NativeFieldInfoPtr_NativeProgressMaxValue;
	}
}
