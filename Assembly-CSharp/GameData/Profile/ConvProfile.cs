using System;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002CB RID: 715
	public class ConvProfile : ScriptableObject
	{
		// Token: 0x06005875 RID: 22645 RVA: 0x001C8984 File Offset: 0x001C6B84
		// Note: this type is marked as 'beforefieldinit'.
		static ConvProfile()
		{
			Il2CppClassPointerStore<ConvProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "ConvProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConvProfile>.NativeClassPtr);
			ConvProfile.NativeFieldInfoPtr_conversations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvProfile>.NativeClassPtr, "conversations");
			ConvProfile.NativeFieldInfoPtr_convLanguageFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvProfile>.NativeClassPtr, "convLanguageFile");
			ConvProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvProfile>.NativeClassPtr, 100681264);
		}

		// Token: 0x06005876 RID: 22646 RVA: 0x001C89F0 File Offset: 0x001C6BF0
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConvProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConvProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005877 RID: 22647 RVA: 0x0002F697 File Offset: 0x0002D897
		public ConvProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x06005878 RID: 22648 RVA: 0x001C8A2C File Offset: 0x001C6C2C
		// (set) Token: 0x06005879 RID: 22649 RVA: 0x0002F6A0 File Offset: 0x0002D8A0
		public unsafe Il2CppReferenceArray<WeightedConversationGroup> conversations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConvProfile.NativeFieldInfoPtr_conversations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WeightedConversationGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConvProfile.NativeFieldInfoPtr_conversations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x0600587A RID: 22650 RVA: 0x001C8A5C File Offset: 0x001C6C5C
		// (set) Token: 0x0600587B RID: 22651 RVA: 0x0002F6BF File Offset: 0x0002D8BF
		public unsafe string convLanguageFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConvProfile.NativeFieldInfoPtr_convLanguageFile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConvProfile.NativeFieldInfoPtr_convLanguageFile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003B3C RID: 15164
		private static readonly IntPtr NativeFieldInfoPtr_conversations;

		// Token: 0x04003B3D RID: 15165
		private static readonly IntPtr NativeFieldInfoPtr_convLanguageFile;

		// Token: 0x04003B3E RID: 15166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
