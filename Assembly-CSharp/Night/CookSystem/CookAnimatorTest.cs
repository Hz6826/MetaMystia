using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using NightScene.CookingUtility;
using NightScene.UI.CookingUtility;
using UnityEngine;

namespace Night.CookSystem
{
	// Token: 0x02000054 RID: 84
	public class CookAnimatorTest : MonoBehaviour
	{
		// Token: 0x06000ACA RID: 2762 RVA: 0x000C0AEC File Offset: 0x000BECEC
		// Note: this type is marked as 'beforefieldinit'.
		static CookAnimatorTest()
		{
			Il2CppClassPointerStore<CookAnimatorTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.CookSystem", "CookAnimatorTest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookAnimatorTest>.NativeClassPtr);
			CookAnimatorTest.NativeFieldInfoPtr_m_CookerProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookAnimatorTest>.NativeClassPtr, "m_CookerProfile");
			CookAnimatorTest.NativeFieldInfoPtr_m_CookerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookAnimatorTest>.NativeClassPtr, "m_CookerIndex");
			CookAnimatorTest.NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookAnimatorTest>.NativeClassPtr, "m_State");
			CookAnimatorTest.NativeFieldInfoPtr_m_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookAnimatorTest>.NativeClassPtr, "m_Animator");
			CookAnimatorTest.NativeFieldInfoPtr_m_LastState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookAnimatorTest>.NativeClassPtr, "m_LastState");
			CookAnimatorTest.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookAnimatorTest>.NativeClassPtr, 100665079);
			CookAnimatorTest.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookAnimatorTest>.NativeClassPtr, 100665080);
			CookAnimatorTest.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookAnimatorTest>.NativeClassPtr, 100665081);
			CookAnimatorTest.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookAnimatorTest>.NativeClassPtr, 100665082);
			CookAnimatorTest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookAnimatorTest>.NativeClassPtr, 100665083);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x000C0BE4 File Offset: 0x000BEDE4
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookAnimatorTest.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x000C0C18 File Offset: 0x000BEE18
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookAnimatorTest.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x000C0C4C File Offset: 0x000BEE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40400, XrefRangeEnd = 40408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookAnimatorTest.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x000C0C80 File Offset: 0x000BEE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40408, XrefRangeEnd = 40410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookAnimatorTest.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x000C0CBC File Offset: 0x000BEEBC
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookAnimatorTest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookAnimatorTest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookAnimatorTest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00007F2B File Offset: 0x0000612B
		public CookAnimatorTest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x000C0CF8 File Offset: 0x000BEEF8
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x00007F34 File Offset: 0x00006134
		public unsafe CookerProfile m_CookerProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimatorTest.NativeFieldInfoPtr_m_CookerProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookerProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimatorTest.NativeFieldInfoPtr_m_CookerProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x000C0D28 File Offset: 0x000BEF28
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x00007F53 File Offset: 0x00006153
		public unsafe int m_CookerIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimatorTest.NativeFieldInfoPtr_m_CookerIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimatorTest.NativeFieldInfoPtr_m_CookerIndex)) = value;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x000C0D50 File Offset: 0x000BEF50
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00007F6E File Offset: 0x0000616E
		public unsafe CookController.CookPhase m_State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimatorTest.NativeFieldInfoPtr_m_State);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimatorTest.NativeFieldInfoPtr_m_State)) = value;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x000C0D78 File Offset: 0x000BEF78
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00007F89 File Offset: 0x00006189
		public unsafe CookAnimator m_Animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimatorTest.NativeFieldInfoPtr_m_Animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookAnimator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimatorTest.NativeFieldInfoPtr_m_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x000C0DA8 File Offset: 0x000BEFA8
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00007FA8 File Offset: 0x000061A8
		public unsafe CookController.CookPhase m_LastState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimatorTest.NativeFieldInfoPtr_m_LastState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimatorTest.NativeFieldInfoPtr_m_LastState)) = value;
			}
		}

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeFieldInfoPtr_m_CookerProfile;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeFieldInfoPtr_m_CookerIndex;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeFieldInfoPtr_m_State;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeFieldInfoPtr_m_Animator;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeFieldInfoPtr_m_LastState;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
