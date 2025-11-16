using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003E0 RID: 992
	public class COM_ACharacter_Jump : PlayableAsset
	{
		// Token: 0x06007622 RID: 30242 RVA: 0x00228340 File Offset: 0x00226540
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_Jump()
		{
			Il2CppClassPointerStore<COM_ACharacter_Jump>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_Jump");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_Jump>.NativeClassPtr);
			COM_ACharacter_Jump.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Jump>.NativeClassPtr, "label");
			COM_ACharacter_Jump.NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Jump>.NativeClassPtr, "startPoint");
			COM_ACharacter_Jump.NativeFieldInfoPtr_jumpHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Jump>.NativeClassPtr, "jumpHeight");
			COM_ACharacter_Jump.NativeFieldInfoPtr_jumpCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Jump>.NativeClassPtr, "jumpCount");
			COM_ACharacter_Jump.NativeFieldInfoPtr_jumpInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Jump>.NativeClassPtr, "jumpInterval");
			COM_ACharacter_Jump.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Jump>.NativeClassPtr, "shouldWaitForFinish");
			COM_ACharacter_Jump.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Jump>.NativeClassPtr, 100687491);
			COM_ACharacter_Jump.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Jump>.NativeClassPtr, 100687492);
		}

		// Token: 0x06007623 RID: 30243 RVA: 0x00228410 File Offset: 0x00226610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292615, XrefRangeEnd = 292640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_Jump.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007624 RID: 30244 RVA: 0x00228478 File Offset: 0x00226678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292640, XrefRangeEnd = 292641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_Jump() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_Jump>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_Jump.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007625 RID: 30245 RVA: 0x0003FE92 File Offset: 0x0003E092
		public COM_ACharacter_Jump(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002857 RID: 10327
		// (get) Token: 0x06007626 RID: 30246 RVA: 0x002284B4 File Offset: 0x002266B4
		// (set) Token: 0x06007627 RID: 30247 RVA: 0x0003FE9B File Offset: 0x0003E09B
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002858 RID: 10328
		// (get) Token: 0x06007628 RID: 30248 RVA: 0x002284DC File Offset: 0x002266DC
		// (set) Token: 0x06007629 RID: 30249 RVA: 0x0003FEBA File Offset: 0x0003E0BA
		public unsafe float startPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump.NativeFieldInfoPtr_startPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump.NativeFieldInfoPtr_startPoint)) = value;
			}
		}

		// Token: 0x17002859 RID: 10329
		// (get) Token: 0x0600762A RID: 30250 RVA: 0x00228504 File Offset: 0x00226704
		// (set) Token: 0x0600762B RID: 30251 RVA: 0x0003FED5 File Offset: 0x0003E0D5
		public unsafe float jumpHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump.NativeFieldInfoPtr_jumpHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump.NativeFieldInfoPtr_jumpHeight)) = value;
			}
		}

		// Token: 0x1700285A RID: 10330
		// (get) Token: 0x0600762C RID: 30252 RVA: 0x0022852C File Offset: 0x0022672C
		// (set) Token: 0x0600762D RID: 30253 RVA: 0x0003FEF0 File Offset: 0x0003E0F0
		public unsafe int jumpCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump.NativeFieldInfoPtr_jumpCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump.NativeFieldInfoPtr_jumpCount)) = value;
			}
		}

		// Token: 0x1700285B RID: 10331
		// (get) Token: 0x0600762E RID: 30254 RVA: 0x00228554 File Offset: 0x00226754
		// (set) Token: 0x0600762F RID: 30255 RVA: 0x0003FF0B File Offset: 0x0003E10B
		public unsafe float jumpInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump.NativeFieldInfoPtr_jumpInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump.NativeFieldInfoPtr_jumpInterval)) = value;
			}
		}

		// Token: 0x1700285C RID: 10332
		// (get) Token: 0x06007630 RID: 30256 RVA: 0x0022857C File Offset: 0x0022677C
		// (set) Token: 0x06007631 RID: 30257 RVA: 0x0003FF26 File Offset: 0x0003E126
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x04004E40 RID: 20032
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004E41 RID: 20033
		private static readonly IntPtr NativeFieldInfoPtr_startPoint;

		// Token: 0x04004E42 RID: 20034
		private static readonly IntPtr NativeFieldInfoPtr_jumpHeight;

		// Token: 0x04004E43 RID: 20035
		private static readonly IntPtr NativeFieldInfoPtr_jumpCount;

		// Token: 0x04004E44 RID: 20036
		private static readonly IntPtr NativeFieldInfoPtr_jumpInterval;

		// Token: 0x04004E45 RID: 20037
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x04004E46 RID: 20038
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E47 RID: 20039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
